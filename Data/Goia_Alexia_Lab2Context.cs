using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Goia_Alexia_Lab2.Models;

namespace Goia_Alexia_Lab2.Data
{
    public class Goia_Alexia_Lab2Context : DbContext
    {
        public Goia_Alexia_Lab2Context (DbContextOptions<Goia_Alexia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Goia_Alexia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Goia_Alexia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Goia_Alexia_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
