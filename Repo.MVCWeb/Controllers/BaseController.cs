using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Repo.MVCWeb.Controllers
{
	public class BaseController : Controller
	{
		protected readonly IUnitOfWork _context;

		public BaseController(IUnitOfWork context)
		{

			 
            _context = context;
		}
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			var categ = _context.Categories.GetAll();
			//ViewBag.categ = categ;
			ViewData["categ"] = categ;
			base.OnActionExecuting(context);
		}
	}
}
