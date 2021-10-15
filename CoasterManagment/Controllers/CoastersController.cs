using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoasterManagment.Data;
using CoasterManagment.Models;

namespace CoasterManagment.Controllers
{
    public class CoastersController : Controller
    {

        public ActionResult Home()
        {
            return View();
        }

        // GET: Coasters
        public ActionResult Index()
        {
            return View(SeedData.Coasters);
        }

        // GET: Coasters/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coaster = SeedData.Coasters.FirstOrDefault(m => m.Id == id);
            if (coaster == null)
            {
                return NotFound();
            }

            return View(coaster);
        }

        // GET: Coasters/Create
        public IActionResult Create()
        {
            ViewBag.Colors = new List<SelectListItem>
            {
                new SelectListItem {Text = "Red", Value = "Red"},
                new SelectListItem {Text = "Yellow", Value = "Yellow"},
                new SelectListItem {Text = "Orange", Value = "Orange"},
                new SelectListItem {Text = "Blue", Value = "Blue"},
                new SelectListItem {Text = "White", Value = "White"},
                new SelectListItem {Text = "Black", Value = "Black"},
                new SelectListItem {Text = "Pink", Value = "Pink"},
                new SelectListItem {Text = "Brown", Value = "Brown"}
            };

            ViewBag.Types = new List<SelectListItem>
            {
                new SelectListItem {Text = "Accelerator", Value = "Accelerator"},
                new SelectListItem {Text = "FlyingRoller", Value = "FlyingRoller"},
                new SelectListItem {Text = "BobsledRoller", Value = "BobsledRoller"},
                new SelectListItem {Text = "StandUp", Value = "StandUp"},
                new SelectListItem {Text = "FloorlessRoller", Value = "FloorlessRoller"},
                new SelectListItem {Text = "Dive", Value = "Dive"},
                new SelectListItem {Text = "InvertedRoller", Value = "InvertedRoller"}
            };

            return View();
        }

        // POST: Coasters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Color,Type,Size,Rating")] Coaster coaster)
        {
            coaster.Id = Guid.NewGuid().ToString();
            coaster.CreatedDate = DateTime.Now;
            coaster.ModifiedDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                SeedData.Coasters.Add(coaster);
                return RedirectToAction(nameof(Index));
            }
            return View(coaster);
        }

        // GET: Coasters/Edit/5
        public ActionResult Edit(string id)
        {
            ViewBag.Colors = new List<SelectListItem>
            {
                new SelectListItem {Text = "Red", Value = "Red"},
                new SelectListItem {Text = "Yellow", Value = "Yellow"},
                new SelectListItem {Text = "Orange", Value = "Orange"},
                new SelectListItem {Text = "Blue", Value = "Blue"},
                new SelectListItem {Text = "White", Value = "White"},
                new SelectListItem {Text = "Black", Value = "Black"},
                new SelectListItem {Text = "Pink", Value = "Pink"},
                new SelectListItem {Text = "Brown", Value = "Brown"}
            };

            ViewBag.Types = new List<SelectListItem>
            {
                new SelectListItem {Text = "Accelerator", Value = "Accelerator"},
                new SelectListItem {Text = "FlyingRoller", Value = "FlyingRoller"},
                new SelectListItem {Text = "BobsledRoller", Value = "BobsledRoller"},
                new SelectListItem {Text = "StandUp", Value = "StandUp"},
                new SelectListItem {Text = "FloorlessRoller", Value = "FloorlessRoller"},
                new SelectListItem {Text = "Dive", Value = "Dive"},
                new SelectListItem {Text = "InvertedRoller", Value = "InvertedRoller"}
            };
            if (id == null)
            {
                return NotFound();
            }

            var coaster = SeedData.Coasters.FirstOrDefault(m => m.Id == id);
            if (coaster == null)
            {
                return NotFound();
            }
            return View(coaster);
        }

        // POST: Coasters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, [Bind("Id,Color,Type,Size,CreatedDate,Rating")] Coaster coaster)
        {
            coaster.ModifiedDate = DateTime.Now;
            if (id != coaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var updatedCoaster = SeedData.Coasters
                        .FirstOrDefault(m => m.Id == id);
                    updatedCoaster.Size = coaster.Size;
                    updatedCoaster.Rating = coaster.Rating;
                    updatedCoaster.Type = coaster.Type;
					updatedCoaster.Color = coaster.Color;
                    updatedCoaster.ModifiedDate = coaster.ModifiedDate;

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoasterExists(coaster.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(coaster);
        }

        // GET: Coasters/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coaster = SeedData.Coasters
                .FirstOrDefault(m => m.Id == id);
            if (coaster == null)
            {
                return NotFound();
            }

            return View(coaster);
        }

        // POST: Coasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var coaster = SeedData.Coasters
               .FirstOrDefault(m => m.Id == id);
            if (coaster != null)
                SeedData.Coasters.Remove(coaster);
            return RedirectToAction(nameof(Index));
        }

        private bool CoasterExists(string id)
        {
            return SeedData.Coasters.Any(e => e.Id == id);
        }
    }
}
