using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Managers.DirectionsManager;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DirectionsController : Controller
    {
        private readonly IDirectionsManager Manager;
        public DirectionsController(IDirectionsManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> Directions()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Directions directions)
        {
            await Manager.Add(directions);
            return RedirectToAction(nameof(Directions));
        }
        [HttpGet]
        public async Task<ActionResult> DeleteDirections(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(Directions));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateDirections(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateDirections(int id, Directions directions)
        {
            await Manager.UpdateById(id, directions);
            return RedirectToAction(nameof(Directions));
        }
    }
}
