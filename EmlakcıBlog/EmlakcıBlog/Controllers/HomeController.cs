using Emlak.Data.Context;
using Microsoft.AspNetCore.Mvc;


namespace EmlakcıBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }




        public IActionResult Index()
        {
            var list = _dbContext.Advertis.ToList();
            return View(list);
        }

        public IActionResult Details()
        {
            var list = _dbContext.Users.ToList();
            return View(list);
        }  

        
    }
}
