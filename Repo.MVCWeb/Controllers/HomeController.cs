using Entities;
using Microsoft.AspNetCore.Mvc;
using Repo.MVCWeb.Models;
using System.Diagnostics;

namespace Repo.MVCWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _db;

        public HomeController(IUnitOfWork db)
        {
            _db= db;    
        }
        public IActionResult Index()
        {
           
            
            return View(_db.Products.GetAll());
        }
        public IActionResult Details(int id)
        {
			
			return View(_db.Products.GetById(id));
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