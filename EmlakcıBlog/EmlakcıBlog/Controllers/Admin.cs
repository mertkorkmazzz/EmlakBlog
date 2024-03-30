using Emlak.Data.Context;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Entity.Entities;
using System.Xml;

namespace EmlakcıBlog.Controllers
{
    public class Admin : Controller
    {
        private readonly AppDbContext _dbContext;

        public Admin(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }



        public IActionResult List()
        {
            var list = _dbContext.Advertis.ToList();
            return View(list);
        }
        public IActionResult EditList()
        {
            var list = _dbContext.Advertis.ToList();
            return View(list);
        }
        public IActionResult DeletList()
        {
            var list = _dbContext.Advertis.ToList();
            return View(list);
        }


        public IActionResult Edit(int id)
        {

            var edit = _dbContext.Advertis.Find(id); 
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(Advert advert)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Advertis.Update(advert);
               _dbContext.SaveChanges();
                return RedirectToAction("List");
            }
            return View(advert);
        }


        public IActionResult Delet(int id)
        {
            var entity = _dbContext.Advertis.Find(id);
            if (entity == null)
            {
                return NotFound();
            }

            _dbContext.Advertis.Remove(entity);
            _dbContext.SaveChanges();

            return RedirectToAction("List");
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Advert entity)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Advertis.Add(entity);
                _dbContext.SaveChanges();

                return RedirectToAction("List");
            }

            return View(entity);
        }

    }
}
