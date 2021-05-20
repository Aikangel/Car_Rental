using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRental.Models;

namespace CarRental.Data
{
    public class ProkatContext : DbContext
    {
        public ProkatContext (DbContextOptions<ProkatContext> options)
            : base(options)
        {
        }

        public DbSet<CarRental.Models.CarBrands> CarBrands { get; set; }
    }
}
