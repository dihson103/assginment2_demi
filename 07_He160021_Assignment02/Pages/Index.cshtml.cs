using _07_He160021_Assignment02.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _07_He160021_Assignment02.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly _07_He160021_Assignment02.Models.Assignment02Context _context;

        public IndexModel(ILogger<IndexModel> logger, _07_He160021_Assignment02.Models.Assignment02Context context)
        {
            _logger = logger;
            _context = context;
        }

        public List<Product> Products { get; set; }

        public void OnGet()
        {
            if(_context.Products != null)
            {
                Products = _context.Products.ToList();
            }
        }
    }
}