using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoginAndRegister.Models;

namespace LoginAndRegister.Data
{
    public class LoginAndRegisterContext : DbContext
    {
        public LoginAndRegisterContext (DbContextOptions<LoginAndRegisterContext> options)
            : base(options)
        {
        }

        public DbSet<LoginAndRegister.Models.User> User { get; set; }
    }
}
