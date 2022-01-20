﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClutchCodersWebApp.Data;
using ClutchCodersWebApp.Models;

namespace ClutchCodersWebApp.Pages.PhotoCRUD
{
    public class CreateModel : PageModel
    {
        private readonly ClutchCodersWebApp.Data.ApplicationDbContext _context;

        public CreateModel(ClutchCodersWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Photo Photo { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Photos.Add(Photo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
