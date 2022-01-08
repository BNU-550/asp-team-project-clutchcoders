using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClutchCodersWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClutchCodersWebApp.Pages
{
    public class MyAccountModel : PageModel
    {
        private readonly ClutchCodersWebApp.Data.ApplicationDbContext _context;

        public MyAccountModel(ClutchCodersWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            string email = User.Identity.Name;

            Person = await _context.People
                .Include(p => p.Address)
                .Include(p => p.PaymentCard)
                .FirstOrDefaultAsync(m => m.Email == email);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
