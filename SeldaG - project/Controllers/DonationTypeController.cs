using Microsoft.AspNetCore.Mvc;
using SeldaG___project.Data;
using SeldaG___project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeldaG___project.Controllers
{
    public class DonationTypeController : Controller
    {
        private readonly AppDb _db;

        public DonationTypeController(AppDb db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<DonationType> objList = _db.DonationType;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DonationType obj)
        {
            _db.DonationType.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.DonationType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.DonationType.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.DonationType.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
