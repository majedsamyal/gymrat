using Gymrat.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Data
{
    public class GymEntityContext : DbContext
    {
        public GymEntityContext(DbContextOptions<GymEntityContext> options) : base(options) { }

        public DbSet<Rat> Rats { get; set; }
    }
}
