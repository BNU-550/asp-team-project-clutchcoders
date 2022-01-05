using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClutchCodersWebApp.Data;
using ClutchCodersWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace ClutchCodersWebApp.Pages.People
{
    [Authorize(Roles ="Staff")]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.People
                .Include(p => p.Address)
                .Include(p => p.PaymentCard).ToListAsync();
        }
    }
}
