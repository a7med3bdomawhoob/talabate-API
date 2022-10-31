﻿using DAL.Idyntity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public  interface ITokenService
    {
        Task<string> CreateToken(AppUser user, UserManager<AppUser> usermanager);
    }
}
