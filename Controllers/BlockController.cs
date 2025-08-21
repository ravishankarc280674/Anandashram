using Anandashram.BAL.Interface;
using Anandashram.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anandashram.Controllers
{
    public class BlockController : Controller
    {
        private readonly ILogger<BlockController> _logger;
        private readonly IInfraStructureBO _infrastructure;
        const int PAGESIZE = 10;

        public BlockController(ILogger<BlockController> logger, IInfraStructureBO infrastructure)
        {
            _logger = logger;
            _infrastructure = infrastructure;
        }

        // GET: HotelBlocks
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchText, int? pageNumber)
        {
            ViewData["CurrentFilter"] = searchText;
            ViewData["TitleSortParm"] = String.IsNullOrEmpty(sortOrder) || sortOrder.Equals("Name") ? "name_desc" : "";

            ViewData["CurrentFilter"] = searchText;
            ViewData["CurrentSort"] = sortOrder;

            return View(await _infrastructure.GetBlockList(sortOrder, currentFilter, searchText, pageNumber, PAGESIZE));
        }

        // GET: HotelBlocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }

        // GET: HotelBlocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HotelBlocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreateUid,CreateDate,Name,WriteUid,WriteDate")] Block hotelBlock)
        {
            return View();
        }

        // GET: HotelBlocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        // POST: HotelBlocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CreateUid,CreateDate,Name,WriteUid,WriteDate")] Block hotelBlock)
        {
            //if (id != hotelBlock.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(hotelBlock);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!HotelBlockExists(hotelBlock.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["CreateUid"] = new SelectList(_context.ResUsers, "Id", "Id", hotelBlock.CreateUid);
            //ViewData["WriteUid"] = new SelectList(_context.ResUsers, "Id", "Id", hotelBlock.WriteUid);
            //return View(hotelBlock);

            return View();
        }

        // GET: HotelBlocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var hotelBlock = await _context.HotelBlocks
            //    .Include(h => h.CreateU)
            //    .Include(h => h.WriteU)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (hotelBlock == null)
            //{
            //    return NotFound();
            //}

            //return View(hotelBlock);
            return View();
        }

// POST: HotelBlocks/Delete/5
[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var hotelBlock = await _context.HotelBlocks.FindAsync(id);
            //if (hotelBlock != null)
            //{
            //    _context.HotelBlocks.Remove(hotelBlock);
            //}

            //await _context.SaveChangesAsync();
            // return RedirectToAction(nameof(Index));
            return View();
        }

        private bool HotelBlockExists(int id)
        {
            //return _context.HotelBlocks.Any(e => e.Id == id);
            return true;
        }
    }
}
