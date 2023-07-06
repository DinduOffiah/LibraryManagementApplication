using LibraryManagementApplication.Models;
using LibraryManagementApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _service;

        public BooksController(IBooksService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //GET : Books/Create
        public async Task<IActionResult> Create()
        {
            var bookCatList = await _service.GetBookCatAsync();
            ViewBag.BookCatList = new SelectList(bookCatList, "BookCategoryId", "Category");
            return View();
        }


        //POST : Books/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("BookId, Title, BookImage, CallNumber, Author, YearOfPublication, Volume, Quantity, BookCategoryId")]Book book)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(book);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        //GET : Books/Details
        public async Task<IActionResult> Details(int id)
        {
            var bookDetails = await _service.GetDetailsAsync(id);
            return View(bookDetails);
        }


        //GET : Books/Edit
        public async Task<IActionResult> Edit (int id)
        {
            var bookData = await _service.GetDetailsAsync(id);
            var bookCatList = await _service.GetBookCatAsync();
            ViewBag.BookCatList = new SelectList(bookCatList, "BookCategoryId", "Category");
            return View(bookData);
        }

        //POST : Books/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("BookId, Title, BookImage, CallNumber, Author, YearOfPublication, Volume, Quantity, BookCategoryId")] Book book)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(id, book);
            }

            return RedirectToAction(nameof(Index));
        }


        //GET : Books/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var toBeDeleted = await _service.GetDetailsAsync(id);
            return View(toBeDeleted);
        }

        //POST : Books/Delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed (int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
