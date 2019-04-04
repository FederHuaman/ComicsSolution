using Comics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comics.Infraestructure.Data.Model
{
    public class ComicsDbContext : DbContext
    {
        public ComicsDbContext(DbContextOptions<ComicsDbContext> options) : base(options)
        {

        }
        public DbSet<Comic> Comics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comic>().ToTable("Comic");
        }
    }
}
