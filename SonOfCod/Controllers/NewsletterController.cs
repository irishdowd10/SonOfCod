using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace SonOfCod.Controllers
{
	public class NewsletterController : Controller
	{
		private ApplicationDbContext db = new ApplicationDbContext();

		public IActionResult Index()
		{
			return View(db.Newsletters.ToList());
		}

		public IActionResult Details(int id)
		{
			var thisNewsletter= db.Newsletters.FirstOrDefault(newsletters => newsletters.Id == id);
			return View(thisNewsletter);
		}

		public IActionResult Subscribe()
		{
			return View();
		}
	
		[HttpPost]
		public IActionResult Subscribe(Newsletter newsletter)
		{
			db.Newsletters.Add(newsletter);
			db.SaveChanges();
			return RedirectToRoute(new { controller = "Home", action = "Index" });
			//return RedirectToAction("Subscribe");
		}
	}
}