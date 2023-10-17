using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _07_He160021_Assignment02.Models;
using Microsoft.AspNetCore.Authorization;

namespace _07_He160021_Assignment02.Pages.Categories
{
    [Authorize(Policy = "MustBeAdmin")]
    public class DetailsModel : PageModel
    {
        private readonly _07_He160021_Assignment02.Models.Assignment02Context _context;

        public DetailsModel(_07_He160021_Assignment02.Models.Assignment02Context context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
