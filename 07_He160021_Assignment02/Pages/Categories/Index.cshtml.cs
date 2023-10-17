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
    public class IndexModel : PageModel
    {
        private readonly _07_He160021_Assignment02.Models.Assignment02Context _context;

        public IndexModel(_07_He160021_Assignment02.Models.Assignment02Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                Category = await _context.Categories.ToListAsync();
            }
        }
    }
}
