using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
	public class Admin : Controller
	{
		// GET: Admin
		public ActionResult Index()
		{
			return View();
		}

		// GET: Admin/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		
	}
}
