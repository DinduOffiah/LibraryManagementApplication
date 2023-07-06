using LibraryManagementApplication.Data;
using LibraryManagementApplication.Models;
using LibraryManagementApplication.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Services
{
    public class BookLendService : IBookLendService
    {
        private readonly AppDbContext _context;

        public BookLendService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(BookLendViewModel bookLend)
        {
            var bookLends = new BookLend();
            bookLends.BookId = bookLend.Book.BookId;
            bookLends.StudentId = bookLend.Student.StudentId;
            await _context.BookLends.AddAsync(bookLends);
            await _context.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.BookLends.FirstOrDefaultAsync(lent => lent.BookLendId == id);
            _context.BookLends.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookLend>> GetAllAsync()
        {
            var lendList = await _context.BookLends.ToListAsync();
            return lendList;
        }

        public async Task<BookLend> GetDetailAsync(int id)
        {
            var lendList =  await _context.BookLends.FirstOrDefaultAsync(lent => lent.BookLendId == id);
            return lendList;
        }

        public async Task<BookLend> UpdateAsync(int id, BookLend bookLend)
        {
            _context.Update(bookLend);
            await _context.SaveChangesAsync();
            return bookLend;
        }

        public async Task<Book> PopulateBookAsync(string title)
        {
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Title.Contains(title));
            return book;
        }

        public async Task<Student> PopulateBorrowerAsync(string regNo)
        {
            var student = await _context.Students.FirstOrDefaultAsync(b => b.RegNo.ToString().Contains(regNo));
            return student;
        }

    }
}
