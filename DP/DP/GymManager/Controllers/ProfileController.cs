using GymManager.Models;
using GymManager.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using GymManager.Infrastructure.Acl;
using GymManager.Infrastructure.Authorization;

namespace GymManager.Controllers
{
    [Authorize]
    public class ProfileController : BaseController
    {
        public ProfileController(IPrincipal principal, DbContext dbContext, AclDbContext aclDbContext, ILogger<BaseController> logger) : base(principal, dbContext, aclDbContext, logger)
        {
        }

        [HttpGet("panel-uzytkownika")]
        public async Task<IActionResult> Index()
        {
            var table = Services.ExercisesService.PrepareExercises(_dbContext);
            ViewBag.User = await GetCurrentUserEntity();

            return View(table);
        }

        [HttpGet("panel-uzytkownika/dieta")]
        public async Task<IActionResult> Diet()
        {
            var user = await GetCurrentUserEntity();
            ViewBag.User = user;
            ViewBag.FileExist = System.IO.File.Exists(Directory.GetCurrentDirectory() + "\\wwwroot\\Diet\\" + user.UserId + ".pdf");
            return View();
        }

        [HttpGet("panel-uzytkownika/plan-treningowy")]
        public async Task<IActionResult> TrainingPlan()
        {
            var user = await GetCurrentUserEntity();
            ViewBag.User = user;
            ViewBag.FileExist = System.IO.File.Exists(Directory.GetCurrentDirectory() + "\\wwwroot\\TrainingPlan\\" + user.UserId + ".pdf");
            return View();
        }

        [HttpGet("panel-uzytkownika/karnety")]
        public async Task<IActionResult> Discounts()
        {
            var discounts = await _aclDbContext.Query<Discount>().ToListAsync();
            ViewBag.User = await GetCurrentUserEntity();
            return View(discounts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
