using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class ContactController : Controller
	{
		MyPortfolioContext context= new MyPortfolioContext();
		public IActionResult ContactList()
		{
			ViewBag.id = context.ContextId;
			var value= context.Contacts.ToList();
			return View(value);
		}
		[HttpGet]
		public IActionResult CreateContact() 
		{
			return View();

		}
		[HttpPost]
		public IActionResult CreateContact(Contact contact)
		{

			context.Contacts.Add(contact);
			context.SaveChanges();
			return RedirectToAction("ContactList");
		}

		public IActionResult DeleteContact(int id)
		{
			var value=context.Contacts.Find(id);
			context.Remove(value);
			context.SaveChanges();
			return RedirectToAction("ContactList");
		}


	}
}
