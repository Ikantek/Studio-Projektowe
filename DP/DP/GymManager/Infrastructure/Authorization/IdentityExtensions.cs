using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace GymManager.Infrastructure.Authorization
{
    public static class IdentityExtensions
    {
        public const string UserIdClaim = "UserId";
        public const string RoleIdClaim = "RoleId";
        public const string FullNameClaim = "UserName";

        public static int? GetUserId(this IPrincipal principal)
        {
            if (principal.Identity != null && principal.Identity.IsAuthenticated && principal.Identity is ClaimsIdentity claimsIdentity)
            {
                var userClaim = claimsIdentity.FindFirst(IdentityExtensions.UserIdClaim);

                if (userClaim != null && Int32.TryParse(userClaim.Value, out var userId))
                    return userId;
            }

            return null;
        }

        public static int? GetRoleId(this IPrincipal principal)
        {
            if (principal.Identity != null && principal.Identity.IsAuthenticated && principal.Identity is ClaimsIdentity claimsIdentity)
            {
                var roleClaim = claimsIdentity.FindFirst(IdentityExtensions.RoleIdClaim);

                if (roleClaim != null && Int32.TryParse(roleClaim.Value, out var roleId))
                    return roleId;
            }

            return null;
        }
    }
}
