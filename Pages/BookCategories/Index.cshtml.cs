using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sirbu_Iulia_Laborator2.Data;
using Sirbu_Iulia_Laborator2.Models;

namespace Sirbu_Iulia_Laborator2.Pages.BookCategories
{
    public class IndexModel : PageModel
    {
        private readonly Sirbu_Iulia_Laborator2.Data.Sirbu_Iulia_Laborator2Context _context;

        public IndexModel(Sirbu_Iulia_Laborator2.Data.Sirbu_Iulia_Laborator2Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BookCategory != null)
            {
                BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
            }
        }
    }
}
