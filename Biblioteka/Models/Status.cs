using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Display(Name = "Status Name")]
        public string StatusName { get; set; }
    }
}