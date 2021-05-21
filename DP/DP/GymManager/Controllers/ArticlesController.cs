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
    public class ArticlesController : BaseController
    {
        [HttpGet("artykuly")]
        public IActionResult List()
        {
            var articles = this._dbContext.Set<News>().ToList();
            return View(articles);
        }

        [HttpGet("artykul")]
        public IActionResult Details(int id)
        {
            var article = this._dbContext.Set<News>().First(x=> x.Id==id);
            return View(article);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ArticlesController(IPrincipal principal, DbContext dbContext, AclDbContext aclDbContext, ILogger<BaseController> logger) : base(principal, dbContext, aclDbContext, logger)
        {
        }
    }
}
