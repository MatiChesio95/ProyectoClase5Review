using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoClase5Review.Models;

namespace ProyectoClase5Review.Data
{
    public class CarContext : DbContext
    {
        public CarContext (DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoClase5Review.Models.Car> Car { get; set; } = default!;
    }
}
