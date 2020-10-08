using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Venezia.Models;

namespace Venezia.Data
{
    public class VeneziaContext : DbContext
    {
        public VeneziaContext (DbContextOptions<VeneziaContext> options)
            : base(options)
        {
        }

        public DbSet<Venezia.Models.Car> Car { get; set; }
    }
}
