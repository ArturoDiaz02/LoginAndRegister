using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LoginAndRegister.Data;
using LoginAndRegister.Models;

namespace LoginAndRegister.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly LoginAndRegister.Data.LoginAndRegisterContext _context;

        public IndexModel(LoginAndRegister.Data.LoginAndRegisterContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
