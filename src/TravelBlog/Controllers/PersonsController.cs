using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlogPost.Models;
using TravelBlog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TravelBlog.Controllers
{
    public class PersonsController : Controller
    {
        private TravelDbContext db;

        public PersonsController(TravelDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePerson()
        {
            //ViewBag.PersonId = new SelectList(db.Persons, "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
