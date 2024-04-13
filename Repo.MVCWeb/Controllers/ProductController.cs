using Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Repo.MVCWeb.Controllers
{
	public class ProductController :BaseController
	{
        public ProductController(IUnitOfWork context) :base(context)

		{
            
        }
		public IActionResult Index()
		{
			return View(_context.Products.GetAll());
		}
		public IActionResult Details(int id)
		{
			
			return View(_context.Products.GetById(id));
		}
		public IActionResult AddToCart(int id)
		{
			CookieOptions cookieOptions = new CookieOptions();
			cookieOptions.Expires = DateTime.Now.AddDays(20);
            var p = _context.Products.GetById(id);
            var _oldCookie = Request.Cookies["amazoncart"];
            List<Product> _products = new List<Product>();
            if (_oldCookie != null)
			{
                _products = JsonConvert.DeserializeObject<List<Product>>(_oldCookie);

            }
            _products.Add(p);
            string json = JsonConvert.SerializeObject(_products);
            Response.Cookies.Append("amazoncart", json, cookieOptions);
			Response.Cookies.Append("Toto", "Soso", cookieOptions);
			return RedirectToAction(nameof(Index));
			 
		}
		public IActionResult Cart()
        {
			var amazoncart = Request.Cookies["amazoncart"].ToString();
            var   ps = JsonConvert.DeserializeObject<List<Product>>(amazoncart);
			
            return View( ps);
        }
    }
}
