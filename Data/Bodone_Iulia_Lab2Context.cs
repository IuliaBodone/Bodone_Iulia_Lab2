using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bodone_Iulia_Lab2.Models;

namespace Bodone_Iulia_Lab2.Data
{
    public class Bodone_Iulia_Lab2Context : DbContext
    {
        public Bodone_Iulia_Lab2Context (DbContextOptions<Bodone_Iulia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bodone_Iulia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Bodone_Iulia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Bodone_Iulia_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
