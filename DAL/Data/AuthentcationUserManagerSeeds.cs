using DAL.Idyntity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public  class AuthentcationUserManagerSeeds
    {
        public static  async Task AddUserSeed(UserManager<AppUser> usermanager)
        {
            if(!usermanager.Users.Any())
            {
                var newuser = new AppUser()
                {
                    DesplayName="ahmed abdo",
                    UserName="Ahmed123@",
                    Email="mawhoobahmed99@gmail.com",
                    PhoneNumber="01093910839",

                   address=  new Address()
                    {
                       street="tarkeep",
                       City="cairo",
                       Country="Helwan"
                    }
                   
                };
                await usermanager.CreateAsync(newuser, "P@ssW0rd");

            }
        }
    }
}
