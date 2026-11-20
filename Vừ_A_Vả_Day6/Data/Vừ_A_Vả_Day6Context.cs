using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vừ_A_Vả_Day6.Models;

namespace Vừ_A_Vả_Day6.Data
{
    public class Vừ_A_Vả_Day6Context : DbContext
    {
        public Vừ_A_Vả_Day6Context (DbContextOptions<Vừ_A_Vả_Day6Context> options)
            : base(options)
        {
        }

        public DbSet<Vừ_A_Vả_Day6.Models.Product> Product { get; set; } = default!;
        public DbSet<Vừ_A_Vả_Day6.Models.Genre> Genre { get; set; } = default!;
        public DbSet<Vừ_A_Vả_Day6.Models.Movie> Movie { get; set; } = default!;
    }
}
