﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TH2_CoreRazerContoso.Models;

namespace TH2_CoreRazerContoso.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly TH2_CoreRazerContoso.Models.UniversityContext _context;

        public CreateModel(TH2_CoreRazerContoso.Models.UniversityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Course.Add(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}