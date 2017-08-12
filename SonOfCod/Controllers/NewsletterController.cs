using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Authorization;

namespace SonOfCod.Controllers
{
	public class NewsletterController : Controller
	{
		private ApplicationDbContext db = new ApplicationDbContext();
		//Create your newletter
		[Authorize]
		public IActionResult Create()
		{
			return View();
		}
		[Authorize]
		[HttpPost]
		public IActionResult Create(Newsletter newsletter)
		{
			db.Newsletters.Add(newsletter);
			db.SaveChanges();
			ViewBag.addedNewsletterName = db.Newsletters.Last().Name;
			ViewBag.addedNewsletterEmail = db.Newsletters.Last().Email;
			return View();
		}
	}
}