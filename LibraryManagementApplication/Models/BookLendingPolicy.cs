using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Models
{
    public class BookLendingPolicy
    {
        public int BookLendingPolicyId { get; set; }
        [Required]
        public int MaxNumBooks_Stud { get; set; }
        [Required]
        public int MaxNumBooks_Lect { get; set; }
        [Required]
        public int MaxNumDays_Stud { get; set; }
        [Required]
        public int MaxNumDays_Lect { get; set; }
        [Required]
        public string Penalty_Stud { get; set; }
        [Required]
        public string Penalty_Lect { get; set; }
    }
}
