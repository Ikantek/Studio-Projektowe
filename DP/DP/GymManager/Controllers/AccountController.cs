using GymManager.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using GymManager.Infrastructure.Acl;
using GymManager.Infrastructure.Authorization;
using GymManager.Services;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(IPrincipal principal, DbContext dbContext, AclDbContext aclDbContext, ILogger<BaseController> logger) : base(principal, dbContext, aclDbContext, logger)
        {
        }

        [HttpGet("zaloguj")]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogOn(string email, string password)
        {
            var user = this._dbContext.Set<User>().FirstOrDefault(x => x.Email == email && x.Password == AccountService.CreateMD5(password));

            if (user != null)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Email),
                        new Claim(IdentityExtensions.UserIdClaim, user.UserId.ToString()),
                        new Claim(IdentityExtensions.RoleIdClaim, user.RoleId.ToString()),
                        new Claim(IdentityExtensions.FullNameClaim, user.FullName),
                    };
                var claimsIdentity = new ClaimsIdentity(
                       claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                TempData["Positive"] = true;
                TempData["Title"] = "Gratulacje, zalogowałeś się!";
                TempData["Message"] = "Od teraz możesz przeglądać ceny promocji, swoje wyniki na siłowni oraz sprawdzić przykładowe diety.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Niestety, akcja logowania nie powiodła się!";
                TempData["Message"] = "Spróbuj ponownie lub skontaktuj się z biurem obsługi klienta";
                return RedirectToAction("LogIn", "Account");
            }
        }

        [HttpGet("wyloguj")]
        public async Task<IActionResult> LogOff()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            TempData["Positive"] = true;
            TempData["Title"] = "Sukces!";
            TempData["Message"] = "Akcja wylogowania przebiegła pomyślnie. Od teraz nie masz dostępu do panelu klienta!";
            return RedirectToAction("Index", "Home");
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


    }
}
