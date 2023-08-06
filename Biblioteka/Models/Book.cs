using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Naziv knjige")]
        public string Title { get; set; }

        [Display(Name = "Pisac")]
        public string Writer { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "Kategorija")]
        public string CategoryName { get; set; }

        public int StatusId { get; set; }

        [Display(Name = "Dostupnost")]
        public string StatusName { get; set; }
    }
}