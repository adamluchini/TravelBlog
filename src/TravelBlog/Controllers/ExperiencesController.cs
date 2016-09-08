using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelBlogPost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TravelBlogPost.Controllers
{
    public class ExperiencesController : Controller
    {
        private TravelDbContext db;//= new TravelDbContext();
        public ExperiencesController(TravelDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            //return View(db.Persons.ToList());
            return View(db.Experiences.Include(experiences => experiences.Location).ToList());
        }

        public IActionResult Details(int id)
        {
            var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
            return View(thisExperience);
        }

        public IActionResult Create()
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Destination");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            db.Experiences.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Destination");
            return View(thisExperience);
        }
        [HttpPost]
        public IActionResult Edit(Experience experience)
        {
            db.Entry(experience).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
            return View(thisExperience);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
            db.Experiences.Remove(thisExperience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
