using LibraryManagementApplication.Data;
using LibraryManagementApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Controllers
{
    public class BookLendingPolicysController : Controller
    {
        private readonly AppDbContext _context;

        public BookLendingPolicysController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data =  _context.BookLendingPolicies.ToList();
            return View(data);
        }

        //GET: BookLendingPolicy/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: BookLendingPolicy/Create
        [HttpPost]
        public async Task<IActionResult> Create(BookLendingPolicy bookLendingPolicy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookLendingPolicy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(bookLendingPolicy);
        }

        //GET: BookLendingPolicy/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var policyEdit = await _context.BookLendingPolicies.FindAsync(id);
            return View(policyEdit);
        }

        //POST: BookLendingPolicy/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(BookLendingPolicy bookLendingPolicy)
        {
            if(ModelState.IsValid)
            {
                _context.Update(bookLendingPolicy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(bookLendingPolicy);
        }


        //GET: BookLendingPolicy/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var policyDelete = await _context.BookLendingPolicies.FindAsync(id);
            return View(policyDelete);
        }

        //POST: BookLendingPolicy/Edit
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
                var policyRemove = await _context.BookLendingPolicies.FindAsync(id);
                _context.BookLendingPolicies.Remove(policyRemove);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }


    }
}
