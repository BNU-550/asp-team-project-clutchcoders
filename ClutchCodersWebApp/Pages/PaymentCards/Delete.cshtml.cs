using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClutchCodersWebApp.Data;
using ClutchCodersWebApp.Models;

namespace ClutchCodersWebApp.Pages.PaymentCards
{
    public class DeleteModel : PageModel
    {
        private readonly ClutchCodersWebApp.Data.ApplicationDbContext _context;

        public DeleteModel(ClutchCodersWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PaymentCard PaymentCard { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaymentCard = await _context.PaymentCards.FirstOrDefaultAsync(m => m.CardId == id);

            if (PaymentCard == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PaymentCard = await _context.PaymentCards.FindAsync(id);

            if (PaymentCard != null)
            {
                _context.PaymentCards.Remove(PaymentCard);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
