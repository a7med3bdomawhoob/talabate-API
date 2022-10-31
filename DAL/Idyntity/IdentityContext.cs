
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Idyntity
{

    //Add-Migration InitialIdentity -c IdentityDbContext -o Identity/Migrations
    //Update-Database -context IdentityDbContext
    public class IdentityContext : IdentityDbContext<AppUser>  //for register and login
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }


    }
}
