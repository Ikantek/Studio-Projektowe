using GymManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using GymManager.Infrastructure.Acl;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Controllers
{
    public class TrainerController : BaseController
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public TrainerController(IPrincipal principal, DbContext dbContext, AclDbContext aclDbContext, ILogger<BaseController> logger) : base(principal, dbContext, aclDbContext, logger)
        {
        }
    }
}
