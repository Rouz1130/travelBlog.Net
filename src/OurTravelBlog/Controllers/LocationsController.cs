using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OurTravelBlog.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace OurTravelBlog.Controllers
{
    public class LocationsController : Controller
    {
        // GET: /<controller>/
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(db.Locations.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(location => location.id == id);
                return View(thisLocation);
        }
        public IActionResult Edit(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(Locations => Locations.id == id);
            return View(thisLocation);
        }
        [HttpPost]
        public IActionResult Edit(Location location)
        {
            db.Entry(location).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var chosenlocation = db.Locations.FirstOrDefault(location => location.id == id);
            return View(chosenlocation);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var chosenlocation = db.Locations.FirstOrDefault(location => location.id == id);
            db.Locations.Remove(chosenlocation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
