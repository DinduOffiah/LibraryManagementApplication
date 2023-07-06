using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Models
{
    public class Lecturer
    {
        public int LecturerId { get; set; }
        [Required]
        public int StaffNo { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string OtherName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNum { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
