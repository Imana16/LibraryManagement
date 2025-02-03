using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LibraryManagement
{
    public class BorrowedBook
    {
        public int BorrowedBookID { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Fine { get; set; }
        public string PaymentStatus { get; set; } // Paid or Unpaid
    }



}
