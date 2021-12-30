using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClutchCodersWebApp.Data;
using ClutchCodersWebApp.Models;

namespace ClutchCodersWebApp.Pages.People
{
    public class DetailsModel : PageModel
    {
        private readonly ClutchCodersWebApp.Data.ApplicationDbContext _context;

        public DetailsModel(ClutchCodersWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.People
                .Include(p => p.Address)
                .Include(p => p.PaymentCard).FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
