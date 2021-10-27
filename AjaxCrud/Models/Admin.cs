using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCrud.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPasword { get; set; }
    }
}
