using GymManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymManager.Infrastructure.Acl;
using GymManager.Infrastructure.Authorization;

namespace GymManager.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ILogger<BaseController> Logger;
        private readonly IPrincipal _principal;
        private DbContext _internalDbContext;
        protected GymDbContext _dbContext => _internalDbContext as GymDbContext;
        protected AclDbContext _aclDbContext;

        protected async Task<User> GetCurrentUserEntity() => await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == _principal.GetUserId());

        protected BaseController(IPrincipal principal, DbContext dbContext, AclDbContext aclDbContext, ILogger<BaseController> logger)
        {
            _principal = principal;
            _internalDbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _aclDbContext = aclDbContext ?? throw new ArgumentNullException(nameof(aclDbContext));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
