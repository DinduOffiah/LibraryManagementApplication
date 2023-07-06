using LibraryManagementApplication.Data;
using LibraryManagementApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Controllers
{
    public class BookCategorysController : Controller
    {
        private readonly AppDbContext _context;

        public BookCategorysController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.BookCategories.ToList();

            return View(data);
        }

        //GET: BookCategory/Create
        public IActionResult Create() 
        {
            return View();
        }

        //POST: BookCategory/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Category")] BookCategory bookCategorys)
        {
            if (ModelState.IsValid)
            {
                _context.BookCategories.Add(bookCategorys);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(bookCategorys);
        }

        //GET: BookCategory/Edit
        public async Task<IActionResult> Edit(int id) 
        {
            var categoryEdit = await _context.BookCategories.FindAsync(id);
            return View(categoryEdit);
        }

        //POST: BookCategory/Edit
        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id, Category")] BookCategory bookCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Update(bookCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(bookCategory);
        }

        // GET: BookCategory/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var categoryData = await _context.BookCategories.FindAsync(id);
            return View(categoryData);
        }

        // POST: BookCategory/Delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoryDelete = await _context.BookCategories.FindAsync(id);
            _context.BookCategories.Remove(categoryDelete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
