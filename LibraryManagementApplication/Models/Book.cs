using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string BookImage { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string CallNumber { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime YearOfPublication { get; set; }
        [Required]
        public string Volume { get; set; }
        [Required]
        public int Quantity { get; set; }

        [Required(ErrorMessage ="Book Category is required!")]

        [ForeignKey("BookCategory")]
        public int BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }
    }
}
