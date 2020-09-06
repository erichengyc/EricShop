using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EricShop.Models;
using Microsoft.AspNetCore.Identity;

namespace EricShop.Controllers
{
    public class Aesops1Controller : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public Aesops1Controller(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private const string Admin = "admin@admin.com";
        private const string AllItems = "";

        // GET: Aesops1
        public async Task<IActionResult> Index()
        {
            //// GET UserName from logged-in user and display items that user on sell page
            //var username = _userManager.GetUserName(User);

            //// if username is admin@admin.com (admin user) then show ALL ITEMS from Product Table
            //if (username == Admin)
            //{
            //    var user = from u in _context.Aesops
            //               select u;
            //    user = user.Where(u => u.UserName.Contains(AllItems));
            //    return View(await user.ToListAsync());
            //}
            //// else show items from Product Table for current user
            //else
            //{
            //    var user = from u in _context.Aesops
            //               select u;
            //    user = user.Where(u => u.UserName.Contains(username));
            //    return View(await user.ToListAsync());
            //}

            var appDbContext = _context.Aesops.Include(a => a.Category);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Aesops1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aesop = await _context.Aesops
                .Include(a => a.Category)
                .FirstOrDefaultAsync(m => m.AesopId == id);
            if (aesop == null)
            {
                return NotFound();
            }

            return View(aesop);
        }

        // GET: Aesops1/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            return View();
        }

        // POST: Aesops1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AesopId,Name,Description,Price,ImageUrl,ImageThumbnailUrl,IsOnSale,IsInStock,CategoryId,UserName")] Aesop aesop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aesop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", aesop.CategoryId);
            return View(aesop);
        }

        // GET: Aesops1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aesop = await _context.Aesops.FindAsync(id);
            if (aesop == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", aesop.CategoryId);
            return View(aesop);
        }

        // POST: Aesops1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AesopId,Name,Description,Price,ImageUrl,ImageThumbnailUrl,IsOnSale,IsInStock,CategoryId,UserName")] Aesop aesop)
        {
            if (id != aesop.AesopId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aesop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AesopExists(aesop.AesopId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", aesop.CategoryId);
            return View(aesop);
        }

        // GET: Aesops1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aesop = await _context.Aesops
                .Include(a => a.Category)
                .FirstOrDefaultAsync(m => m.AesopId == id);
            if (aesop == null)
            {
                return NotFound();
            }

            return View(aesop);
        }

        // POST: Aesops1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aesop = await _context.Aesops.FindAsync(id);
            _context.Aesops.Remove(aesop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AesopExists(int id)
        {
            return _context.Aesops.Any(e => e.AesopId == id);
        }
    }
}
