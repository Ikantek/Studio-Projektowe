using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using GymManager.Infrastructure.Authorization;
using GymManager.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Acl
{
    public class AclDbContext
    {
        private readonly DbContext _context;
        private readonly IPrincipal _principal;

        public AclDbContext(DbContext context, IPrincipal principal)
        {
            _context = context;
            _principal = principal;
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : BaseEntity
        {
            var userId = _principal.GetUserId();
            var tableNameAttribute =
                typeof(TEntity).GetCustomAttributes().OfType<AclTableNameAttribute>().FirstOrDefault();
            if (tableNameAttribute == null)
                return _context.Set<TEntity>();

            var userRoles = GetUserRolesHierarchy();

            var aclTableAllPermissions = _context.Set<Models.Acl>()
                .Where(x => x.TableName.ToLower() == tableNameAttribute.TableName.ToLower());
            var aclTablePermissionsQuery = aclTableAllPermissions.Where(x =>
                        x.UserId == userId && x.Action == AclAction.Accept || x.RoleId.HasValue &&
                        userRoles.Contains(x.RoleId.Value) &&
                        !(x.UserId == userId && x.Action == AclAction.Reject) && !aclTableAllPermissions.Any(y => y.ObjectId == x.ObjectId && y.RoleId == x.RoleId && y.UserId == userId)
                    );

            return _context.Set<TEntity>().Where(x => aclTablePermissionsQuery.Any(y => y.ObjectId == x.Id));
        }

        private int[] GetUserRolesHierarchy()
        {
            var roleId = (this._context.Set<User>().FirstOrDefault(x => x.UserId == _principal.GetUserId()))
                ?.RoleId;
            var sql = $"WITH RECURSIVE rolesCTE " +
                      "AS ( " +
                      "SELECT r1.role_id, r1.name, r1.parent_id " +
                      "FROM public.\"role\" r1 " +
                      $"WHERE r1.role_id = {roleId}" +
                      "UNION ALL " +
                      "SELECT r2.role_id, r2.name, r2.parent_id " +
                      "FROM public.\"role\" r2 " +
                      "JOIN rolesCTE ON r2.parent_id = rolesCTE.role_id" +
                      ")" +
                      $"SELECT * FROM rolesCTE;";
            var roles = (_context.Set<Role>().FromSqlRaw(sql).ToList()).Select(x => x.RoleId).ToArray();
            return roles;
        }
    }
}