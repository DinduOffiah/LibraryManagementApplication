using LibraryManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Services
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAllAsync();

        Task AddAsync(Book book);

        Task<Book> GetDetailsAsync(int id);

        Task<Book> UpdateAsync(int id, Book book);

        Task DeleteAsync(int id);

        Task<IEnumerable<BookCategory>> GetBookCatAsync();
    }
}
