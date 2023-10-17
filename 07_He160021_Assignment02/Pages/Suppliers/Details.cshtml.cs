using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _07_He160021_Assignment02.Models;
using Microsoft.AspNetCore.Authorization;

namespace _07_He160021_Assignment02.Pages.Suppliers
{
    [Authorize(Policy = "MustBeAdmin")]
    public class DetailsModel : PageModel
    {
        private readonly _07_He160021_Assignment02.Models.Assignment02Context _context;

        public DetailsModel(_07_He160021_Assignment02.Models.Assignment02Context context)
        {
            _context = context;
        }

      public Supplier Supplier { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Suppliers == null)
            {
                return NotFound();
            }

            var supplier = await _context.Suppliers.FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplier == null)
            {
                return NotFound();
            }
            else 
            {
                Supplier = supplier;
            }
            return Page();
        }
    }
}
