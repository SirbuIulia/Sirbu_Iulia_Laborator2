using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sirbu_Iulia_Laborator2.Data;
using Sirbu_Iulia_Laborator2.Models;

namespace Sirbu_Iulia_Laborator2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Sirbu_Iulia_Laborator2.Data.Sirbu_Iulia_Laborator2Context _context;

        public IndexModel(Sirbu_Iulia_Laborator2.Data.Sirbu_Iulia_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .Include(b => b.Author)
                    .ToListAsync();
            }
        }
    }
}
