using LibraryManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.ViewModel
{
    public class BookLendViewModel
    {
        public Book Book { get; set; }

        public Student Student { get; set; }

        public Lecturer Lecturer { get; set; }


    }

    public class LendReturnType
    {
        public int RegNo { get; set; }      
        public string Title { get; set; }
        public string CallNumber { get; set; }

    }
}
