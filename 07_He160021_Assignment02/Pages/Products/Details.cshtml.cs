using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _07_He160021_Assignment02.Models;

namespace _07_He160021_Assignment02.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly _07_He160021_Assignment02.Models.Assignment02Context _context;

        public DetailsModel(_07_He160021_Assignment02.Models.Assignment02Context context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;
        public Category? Category { get; set; } = default!;
        public Supplier? Supplier { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);
            
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Category = await _context.Categories.FirstOrDefaultAsync(c => product.CategoryId == c.CategoryId);
                Supplier = await _context.Suppliers.FirstOrDefaultAsync(m => product.SupplierId == m.SupplierId);
                Product = product;
            }
            return Page();
        }
    }
}
