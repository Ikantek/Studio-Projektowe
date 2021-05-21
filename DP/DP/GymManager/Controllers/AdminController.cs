using GymManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GymManager.Models.Enums;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Security.Principal;
using GymManager.Infrastructure.Acl;
using GymManager.Services;
using GymManager.Utilities;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Controllers
{
    public class AdminController : BaseController
    {
        public AdminController(IPrincipal principal, DbContext dbContext, AclDbContext aclDbContext, ILogger<BaseController> logger) : base(principal, dbContext, aclDbContext, logger)
        {
        }
        [HttpGet("panel-managera")]
        public async Task<IActionResult> Index()
        {
            if (isAdmin() && isTrainer())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = await GetCurrentUserEntity();
            var userList = new List<User>();
            if (TempData["userList"] != null)
                userList = JsonConvert.DeserializeObject<List<User>>(TempData["userList"].ToString());
            else
                userList = this._dbContext.Set<User>().ToList();
            return View(userList);
        }

        [HttpGet("menu-karnetow")]
        public async Task<IActionResult> Passes()
        {
            if (isAdmin())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = await GetCurrentUserEntity();
            var discountList = this._dbContext.Set<Discount>().OrderBy(x => x.Id).ToList();
            return View(discountList);
        }

        [HttpGet("panel-managera/dodaj-karnet")]
        public async Task<IActionResult> AddPass()
        {
            if (isAdmin())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = await GetCurrentUserEntity();
            return View();
        }

        [HttpPost]
        public IActionResult AddPassP(string discountName, string discountDescription, string discountValue, string discountCode, string date, int roleId)
        {
            var discount = new Discount();
            discount.DiscountName = discountName;
            discount.DiscountDescription = discountDescription;
            discount.DiscountValue = discountValue;
            discount.DiscountCode = discountCode;
            discount.ExpiryDate = DateTime.Parse(date);
            this._dbContext.Set<Discount>().Add(discount);
            this._dbContext.SaveChanges();

            var newOne = new Acl();
            newOne.RoleId = roleId;
            newOne.TableName = "discounts";
            newOne.ObjectId = this._dbContext.Set<Discount>().First(x => x.DiscountName == discount.DiscountName).Id;

            this._dbContext.Set<Acl>().Add(newOne);
            this._dbContext.SaveChanges();

            TempData["Positive"] = true;
            TempData["Title"] = "Karnet został dodany!";
            TempData["Message"] = "Wszystkie informacje zostały zapisane!";
            return RedirectToAction("Passes", "Admin");
        }

        [HttpPost]
        public IActionResult RemovePass(int passId, int rowNumber)
        {
            var toRemoveDiscount = this._dbContext.Set<Discount>().First(x => x.Id == passId);
            var toRemoveAcl = this._dbContext.Set<Acl>().First(x => x.TableName == "discounts" && x.ObjectId == passId);

            this._dbContext.Set<Discount>().Remove(toRemoveDiscount);
            this._dbContext.Set<Acl>().Remove(toRemoveAcl);
            this._dbContext.SaveChanges();

            TempData["Positive"] = true;
            TempData["Title"] = "Karnet został usunięty!";
            TempData["Message"] = "Wszystkie informacje zostały usunięte!";
            return RedirectToAction("Passes", "Admin");
        }

        [HttpGet("panel-managera/edytuj-karnet")]
        public async Task<IActionResult> EditPass(int passId)
        {
            if (isAdmin())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = await GetCurrentUserEntity();
            var toEdit = this._dbContext.Set<Discount>().First(x => x.Id == passId);
            var doesExist = this._dbContext.Set<Acl>().ToList();
            var roleOwner = this._dbContext.Set<Acl>().FirstOrDefault(x => x.TableName == "discounts" && x.ObjectId == passId)?.RoleId;
            ViewBag.RoleOwner = roleOwner;
            ViewBag.Row = 0;
            return View(toEdit);
        }

        [HttpPost]
        public IActionResult EditPassP(string discountName, int passId, string discountDescription, string discountValue, string discountCode, string date, int roleId, int rowNumber)
        {
            var discount = this._dbContext.Set<Discount>().First(x => x.Id == passId);
            discount.DiscountName = discountName;
            discount.DiscountDescription = discountDescription;
            discount.DiscountValue = discountValue;
            discount.DiscountCode = discountCode;

            discount.ExpiryDate = DateTime.Parse(date);
            var toRemove = this._dbContext.Set<Acl>().First(x => x.TableName == "discounts" && x.ObjectId == passId);
            var newOne = new Acl();
            newOne.RoleId = roleId;
            newOne.TableName = "discounts";
            newOne.ObjectId = passId;
            this._dbContext.Set<Acl>().Remove(toRemove);
            this._dbContext.Set<Acl>().Add(newOne);
            this._dbContext.SaveChanges();

            TempData["Positive"] = true;
            TempData["Title"] = "Karnet został zmieniony!";
            TempData["Message"] = "Wszystkie informacje zostały zapisane!";
            return RedirectToAction("Passes", "Admin");
        }

        [HttpGet("panel-managera/dodaj-diete")]
        public async Task<IActionResult> AddDietTP()
        {
            if (isAdmin() && isTrainer())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = await GetCurrentUserEntity();
            var userList = new List<User>();
            if (TempData["userList"] != null)
                userList = JsonConvert.DeserializeObject<List<User>>(TempData["userList"].ToString());
            else
                userList = this._dbContext.Set<User>().ToList();
            return View(userList);
        }


        [HttpGet("panel-managera/dodaj-uzytkownika")]
        public async Task<IActionResult> AddUser()
        {
            if (isAdmin())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = await GetCurrentUserEntity();
            return View();
        }
        [HttpGet("panel-managera/dodaj-artykul")]
        public async Task<IActionResult> AddArticle()
        {
            if (isAdmin())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = await GetCurrentUserEntity();
            return View();
        }
        [HttpPost]
        public IActionResult AddNewsP(int id, int type, string header, string description)
        {
            var newId = NewsService.GenerateId();
            NewsInterface news = null;
            if (type == (int)NewsEnum.Serious)
                news = new SeriousNewsCreator(newId, type, header, description).GetNews();
            else
                news = new AdvertisingNewsCreator(newId, type, header, description).GetNews();
            NewsService.parseToDB(news, _dbContext);
            TempData["Positive"] = true;
            TempData["Title"] = "Sukces!";
            TempData["Message"] = "Artykuł został dodany";
            return RedirectToAction("Index", "Admin");
        }



        [HttpGet("panel-managera/edytuj-uzytkownika")]
        public async Task<IActionResult> EditUser(int userId)
        {
            if (isAdmin())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.User = await GetCurrentUserEntity();
            var toEdit = this._dbContext.Set<User>().First(x => x.UserId == userId);
            return View(toEdit);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserP(string email, string name, string surname, string password, int roleId, int userId)
        {
            var user = this._dbContext.Set<User>().First(x => x.UserId == userId);
            user.Email = email;
            user.Name = name;
            user.Surname = surname;
            if (!string.IsNullOrEmpty(password))
                user.Password = AccountService.CreateMD5(password);
            user.RoleId = roleId;
            this._dbContext.SaveChanges();
            TempData["Positive"] = true;
            TempData["Title"] = "Sukces";
            TempData["Message"] = "Dane użytkownika zostały zmienione.";
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult AddUserP(string email, string name, string surname, string password, int role)
        {
            var user = new UserBuilder()
                .SetEmail(email)
                .SetName(name)
                .SetSurname(surname)
                .SetPassword(AccountService.CreateMD5(password))
                .SetRoleId(role)
                .Build();
            this._dbContext.Attach(user);
            this._dbContext.SaveChanges();
            TempData["Positive"] = true;
            TempData["Title"] = "Sukces";
            TempData["Message"] = "Użytkownik został stworzony.";
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult DeleteUser(int userId)
        {
            if (isAdmin())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            var toDelete = this._dbContext.Set<User>().First(x => x.UserId == userId);
            this._dbContext.Set<User>().Remove(toDelete);
            this._dbContext.SaveChanges();
            TempData["Positive"] = true;
            TempData["Title"] = "Użytkownik został usunięty!";
            TempData["Message"] = "Prawa dostępu dla wybranego użytkownika zostały zabrane. Od teraz nie może on już dłużej korzystać z naszego serwisu.";
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult Search(string text, string action)
        {
            if (isAdmin() && isTrainer())
            {
                TempData["Positive"] = false;
                TempData["Title"] = "Nie ładnie!";
                TempData["Message"] = "Nie posiadasz uprawnień do tego modułu - włamywanie się jest nielegalne!";
                return RedirectToAction("Index", "Home");
            }
            if (string.IsNullOrEmpty(text))
                return RedirectToAction(action, "Admin");
            var userList = this._dbContext.Set<User>().Where(x => x.Surname.ToLower().Contains(text.ToLower()) || x.Name.ToLower().Contains(text.ToLower()) || x.Email.ToLower().Contains(text.ToLower())).ToList();
            TempData["userList"] = JsonConvert.SerializeObject(userList);
            return RedirectToAction(action, "Admin");
        }

        public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files, int userId, string fileType)
        {
            long size = files.Sum(f => f.Length);

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var filePath = string.Empty;
                    if (fileType == "diet")
                        filePath = Directory.GetCurrentDirectory() + "\\wwwroot\\Diet\\" + userId + ".pdf";
                    if (fileType == "tp")
                        filePath = Directory.GetCurrentDirectory() + "\\wwwroot\\TrainingPlan\\" + userId + ".pdf";

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            TempData["Positive"] = true;
            TempData["Title"] = "Dane zostały przesłane!";
            TempData["Message"] = "Od teraz użytkownik będzie widział plik u siebie w systemie!";

            return Ok(new { count = files.Count, size });
        }

        private bool isAdmin()
        {
            var user = this._dbContext.Set<User>().First(x => x.Email == User.Identity.Name);
            return user.RoleId != (int)RolesEnum.Manager;
        }

        private bool isTrainer()
        {
            var user = this._dbContext.Set<User>().First(x => x.Email == User.Identity.Name);
            return user.RoleId != (int)RolesEnum.Trainer;
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
