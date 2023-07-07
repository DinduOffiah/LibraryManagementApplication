using LibraryManagementApplication.Models;
using LibraryManagementApplication.Services;
using LibraryManagementApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Controllers
{
    public class BookLendsController : Controller
    {
        private readonly IBookLendService _service;

        public BookLendsController(IBookLendService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //GET: BookLend/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: BookLend/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title, RegNo, CallNumber")] LendReturnType bookLend)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(bookLend);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }


        //GET: BookLend/Details
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetDetailAsync(id);
            return View(data);
        }


        //GET: BookLend/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var Data = await _service.GetDetailAsync(id);
            return View(Data);
        }

        //POST: BookLend/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("BookLendId, BookId, StudentId, LecturerId")] BookLend bookLend)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(id, bookLend);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }


        //GET: BookLend/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _service.GetDetailAsync(id);
            return View(data);
        }

        //POST: BookLend/Delete
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


        // Display book data(auto fill)
        // GET: BookLends/AutofillBookDetails
        [HttpGet]
        public async Task<IActionResult> AutofillBookDetails(string title)
        {
            var book = await _service.PopulateBookAsync(title);

            if (book != null)
            {
                var bookDetails = new
                {
                    category = book.BookCategoryId,
                    author = book.Author,
                    callNumber = book.CallNumber,
                    volume = book.Volume,
                    yearOfPublication = book.YearOfPublication
                };

                return Json(bookDetails);
            }

            return Json(null);
        }


        // Display borrower data(auto fill)
        [HttpGet]
        public async Task<IActionResult> AutofillBorrowerDetails(string regNo)
        {
            var borrower = await _service.PopulateBorrowerAsync(regNo);

            if (borrower != null)
            {
                var studentDetails = new
                {
                    name = borrower.Lastname + " " + borrower.OtherName,
                    phoneNumber = borrower.PhoneNum,
                };

                return Json(studentDetails);
            }

            return Json(null);
        }






    }
}
