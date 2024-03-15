using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Managers.SectionsManager;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SectionsController : Controller
    {
        private readonly ISectionsManager Manager;
        public SectionsController(ISectionsManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> Sections()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Sections sections)
        {
            await Manager.Add(sections);
            return RedirectToAction(nameof(Sections));
        }
        [HttpGet]
        public async Task<ActionResult> DeleteSections(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(Sections));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateSections(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateSections(int id, Sections sections)
        {
            await Manager.UpdateById(id, sections);
            return RedirectToAction(nameof(Sections));
        }
    }
}
