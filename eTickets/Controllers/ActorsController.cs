﻿using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Models.Actor> data = await _service.GetAllAsync();
            return View(data);
        }

        // Get: Actors/Create. No data manipulation doesn't need to be async.
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Details/id=1
        public async Task<IActionResult> Details(int id)
        {
            Actor actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }

        // Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            Actor actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            Actor actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Actor actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}