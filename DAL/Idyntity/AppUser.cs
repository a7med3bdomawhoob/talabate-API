
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Idyntity
{
    public  class AppUser:IdentityUser
    {
       // UserManager register 
       //sign in manager login 
        public string DesplayName { get; set; }
        public Address address { get; set; }//Navigational Property Must be Included to display (include) 1 then eager loading
    }
}
