using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Goia_Alexia_Lab2.Data;
using Goia_Alexia_Lab2.Models;

namespace Goia_Alexia_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Goia_Alexia_Lab2.Data.Goia_Alexia_Lab2Context _context;

        public DetailsModel(Goia_Alexia_Lab2.Data.Goia_Alexia_Lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.Publisher)
                .Include(b => b.Author)
                .Include(b => b.BookCategories)
                    .ThenInclude(b => b.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
