using LibraryManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.ViewModel
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string BookImage { get; set; }
       
        public string Title { get; set; }
    
        public string CallNumber { get; set; }
     
        public string Author { get; set; }
      
        public DateTime YearOfPublication { get; set; }
       
        public string Volume { get; set; }
       
        public int Quantity { get; set; }
        
        public IEnumerable<BookCategory> BookCategory { get; set; }
    }
}
