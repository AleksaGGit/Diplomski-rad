using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class Borrowing
    {
        public int Id { get; set; }

        [Display(Name = "Datum iznajmljivanja")]
        public DateTime Date { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public int StatusId { get; set; }

        [Display(Name = "Dostupnost ")]
        public string StatusName { get; set; }

        [Display(Name = "Kategorija")]
        public string CategoryName { get; set; }
    }
}