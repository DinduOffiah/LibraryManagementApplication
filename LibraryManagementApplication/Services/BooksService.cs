using LibraryManagementApplication.Data;
using LibraryManagementApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Services
{
    public class BooksService : IBooksService
    {
        private readonly AppDbContext _context;

        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Books.FirstOrDefaultAsync(n => n.BookId == id);
            _context.Books.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            var bookList = await _context.Books.ToListAsync();
            return bookList;
        }

        public async Task<Book> GetDetailsAsync(int id)
        {
            var details = await _context.Books.FirstOrDefaultAsync(book => book.BookId == id);
            return details;
        }

        public async Task<Book> UpdateAsync(int id, Book book)
        {
            _context.Update(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<IEnumerable<BookCategory>> GetBookCatAsync()
        {
            var catList = await _context.BookCategories.ToListAsync();
            return catList;
        }
    }
}
