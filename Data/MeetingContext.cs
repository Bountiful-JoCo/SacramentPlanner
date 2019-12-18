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
        
        public DbSet<Speaker> Speakers { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
            
        }

        public DbSet<SacramentPlanner.Models.Meeting> Meeting { get; set; }
    }
}
