using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Marcu_Andreea_Cosmina_Lab2.Models;

namespace Marcu_Andreea_Cosmina_Lab2.Data
{
    public class Marcu_Andreea_Cosmina_Lab2Context : DbContext
    {
        public Marcu_Andreea_Cosmina_Lab2Context (DbContextOptions<Marcu_Andreea_Cosmina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Marcu_Andreea_Cosmina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Marcu_Andreea_Cosmina_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Marcu_Andreea_Cosmina_Lab2.Models.Author> Author { get; set; } = default!;
    }


}
