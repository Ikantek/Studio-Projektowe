using GymManager.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GymManager.Models.Enums;
using GymManager.Utilities;
using GymManager.Infrastructure.Acl;

namespace GymManager.Services
{
    public class NewsService
    {
        public static int GenerateId()
        {
            var article = new News();
            return article.Id;
        }
        
        public static void parseToDB(NewsInterface news, GymDbContext dbContext)
        {
            var parsedNews = new News();
            parsedNews.Description = news.Description;
            parsedNews.Header = news.Header;
            parsedNews.Type = news.Type;
            dbContext.Set<News>().Add(parsedNews);
            dbContext.SaveChanges();
        }
    }
}
