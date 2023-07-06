using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Models
{
    public class BookCategory
    {
        public int BookCategoryId { get; set; }

        [Display(Name ="Book Category")]
        public string Category { get; set; }
    }
}
