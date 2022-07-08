using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rekrutacja.Models;

namespace Rekrutacja.Data
{
    public class RekrutacjaContext : DbContext
    {
        public RekrutacjaContext (DbContextOptions<RekrutacjaContext> options)
            : base(options)
        {
        }

        public DbSet<Rekrutacja.Models.Contact> Contact { get; set; }

        public DbSet<Rekrutacja.Models.Category> Category { get; set; }
    }
}
