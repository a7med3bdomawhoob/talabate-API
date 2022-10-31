using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Idyntity
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string street { get; set; }
        [Required]
        public string AppUserId { get; set; }  // ForignKey id in idyntityuser is string Navigational property string accept null by default

    }
}
