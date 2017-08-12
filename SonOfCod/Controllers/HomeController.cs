using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
	public class HomeController : Controller
	{
		private ApplicationDbContext db = new ApplicationDbContext();

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Subscribe()
		{
			ViewData["Message"] = "Welcome! Please sign up for OUR newsletter.";

			return View();
		}

		public IActionResult Admin()
		{
			ViewData["Message"] = "Your admin page.";

			var subscriptions = db.Newsletters.ToList();

			return View(subscriptions);
		}

		public IActionResult Error()
		{
			return View();
		}
	}
}