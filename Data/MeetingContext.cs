using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
        {
        }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
            modelBuilder.Entity<Topic>().ToTable("Topic");
        }
    }
}
