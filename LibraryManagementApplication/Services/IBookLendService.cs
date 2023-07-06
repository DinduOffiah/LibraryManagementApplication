using LibraryManagementApplication.Data;
using LibraryManagementApplication.Models;
using LibraryManagementApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Services
{
    public interface IBookLendService
    {
        Task<IEnumerable<BookLend>> GetAllAsync();

        Task AddAsync(BookLendViewModel bookLend);

        Task<BookLend> GetDetailAsync(int id);

        Task<BookLend> UpdateAsync(int id, BookLend bookLend);

        Task DeleteAsync(int id);

        Task<Book> PopulateBookAsync(string title);

        Task<Student> PopulateBorrowerAsync(string regNo);
    }
}
