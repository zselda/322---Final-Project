using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SeldaG___project.Data;
using SeldaG___project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeldaG___project.Controllers
{
    public class SchoolController : Controller
    {
        private readonly AppDb _db;
      
        public SchoolController(AppDb db)
        {
            _db = db;
        }
      
        public IActionResult Index()
        {
            //ViewData["CurrentFilter"] = searchString;
            //var School = from s in _db.School
            //             select s;
            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    School = School.Where(m => m.Name.Contains(searchString));
            //}
            
            
                IEnumerable<School> objList = _db.School;
                return View(objList);
            
        }
        public IActionResult homeIntro()
        {
            int count = 0;
           

            IEnumerable<School> objList = _db.School;
            foreach (var school in objList)
            {
                count += 1;
            }

                return View(count);

        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(School obj)
        {
            if (ModelState.IsValid)
            {
                _db.School.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id==0)
            {
                return NotFound();
            }
            var obj = _db.School.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(School obj)
        {
            if (ModelState.IsValid)
            {
                _db.School.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.School.Find(id);
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
            var obj = _db.School.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
                _db.School.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            

        }
        public IActionResult SearchSchool()
        {
            return View();
            
        }
        public IActionResult ShowSearchResult(string SearchPhrase = "")
        {
            List<School> schools;
            if (SearchPhrase != "" && SearchPhrase != null)
            {
                schools = _db.School.Where(p => p.Name.Contains(SearchPhrase)).ToList();
            }
            else

                schools = _db.School.ToList();
                return View(schools);

        }


    }
}
