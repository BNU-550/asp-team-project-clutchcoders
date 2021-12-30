using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClutchCodersWebApp.Data;
using ClutchCodersWebApp.Models;

namespace ClutchCodersWebApp.Pages.PaymentCards
{
    public class EditModel : PageModel
    {
        private readonly ClutchCodersWebApp.Data.ApplicationDbContext _context;

        public EditModel(ClutchCodersWebApp.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PaymentCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentCardExists(PaymentCard.CardId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PaymentCardExists(int id)
        {
            return _context.PaymentCards.Any(e => e.CardId == id);
        }
    }
}
