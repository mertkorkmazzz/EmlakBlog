using Emlak.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Entity.Entities;
using System;

namespace EmlakcıBlog.Controllers
{
    public class Login : Controller
    {
		private readonly AppDbContext _dbContext;

		public Login(AppDbContext dbContext)
        {
			this._dbContext = dbContext;
		}

        public IActionResult Logins()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Logins(User model)
        {
            if (ModelState.IsValid)
            {
                var kullanici = _dbContext.Users.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password && x.Email == model.Email);
                if (kullanici != null)
                {
                    // Login işlemini tamamla
                    return RedirectToAction("List", "Admin");
                }

                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!");
            }

            return View(model);
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
		public IActionResult SignUp(User user)
		{
            if(ModelState.IsValid) 
            {
             _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                return RedirectToAction("Logins");
            }
			return View(user);
		}
	}
}
