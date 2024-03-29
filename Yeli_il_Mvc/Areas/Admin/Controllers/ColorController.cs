﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yeli_il_Mvc.Areas.Admin.ViewModels;

using Yeli_il_Mvc.DAL;

using Yeli_il_Mvc.Models;

namespace Yeli_il_Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;

        public ColorController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Color> colors = await _context.Colors.Include(c => c.ProductColors).ToListAsync();
            return View(colors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateColorVM colorVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool result = _context.Colors.Any(c => c.Name.ToLower().Trim() == colorVM.Name.ToLower().Trim());
            if (result)
            {
                ModelState.AddModelError("Name", "This color already exists");
                return View();
            }
            var color = new Color
            {
                Name = colorVM.Name,
            };
            await _context.Colors.AddAsync(color);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            if (id <= 0) return BadRequest();
            Color color = await _context.Colors.FirstOrDefaultAsync(c => c.Id == id);
            if (color is null) return NotFound();
            var vm = new UpdateColorVM
            {
                Name = color.Name
            };
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id,UpdateColorVM colorVM)
        {
            if (!ModelState.IsValid) return View();

            Color existed = await _context.Colors.FirstOrDefaultAsync(c => c.Id == id);
            if (existed is null) return NotFound();
            bool result = _context.Colors.Any(c => c.Name == colorVM.Name && c.Id != id);
            if (result)
            {
                ModelState.AddModelError("Name", "There is already such color");
                return View();
            }

            existed.Name = colorVM.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest();
            var existed = await _context.Colors.FirstOrDefaultAsync(c => c.Id == id);
            if (existed is null) return NotFound();
            _context.Colors.Remove(existed);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0) return BadRequest();
            var color = await _context.Colors
                .Include(c => c.ProductColors)
                .ThenInclude(pc => pc.Product)
                .ThenInclude(p => p.ProductImages).
                FirstOrDefaultAsync(s => s.Id == id);
            if (color == null) return NotFound();

            return View(color);
        }

    }
}
