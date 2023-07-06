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
        public int BookLendId { get; set; }

       
        public int BookId { get; set; }
        public Book Book { get; set; }

     
        public int StudentId { get; set; }
        public Student Student { get; set; }

       
        public int LecturerId { get; set; }
        public Lecturer lecturer { get; set; }



    }
}
