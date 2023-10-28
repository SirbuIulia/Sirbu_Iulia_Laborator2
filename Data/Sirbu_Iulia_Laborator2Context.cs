using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sirbu_Iulia_Laborator2.Models;

namespace Sirbu_Iulia_Laborator2.Data
{
    public class Sirbu_Iulia_Laborator2Context : DbContext
    {
        public Sirbu_Iulia_Laborator2Context (DbContextOptions<Sirbu_Iulia_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Sirbu_Iulia_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Sirbu_Iulia_Laborator2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Sirbu_Iulia_Laborator2.Models.Author>? Author { get; set; }

        public DbSet<Sirbu_Iulia_Laborator2.Models.Category>? Category { get; set; }

        public DbSet<Sirbu_Iulia_Laborator2.Models.BookCategory>? BookCategory { get; set; }
    }
}
