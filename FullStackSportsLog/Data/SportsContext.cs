using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackSportsLog.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStackSportsLog.Data
{
    public class SportsContext : DbContext
    {
        public SportsContext(DbContextOptions<SportsContext> options) : base(options) { }

        public DbSet<AdminUser> AdminUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
