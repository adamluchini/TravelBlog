using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

namespace TravelBlogPost.Models
{
    public class TravelDbContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public TravelDbContext(DbContextOptions<TravelDbContext> options)
            :base(options)
        {
        }

        //public TravelDbContext(DbContextOptions options): base(options)
        //{

        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Experiences_Persons>()
                .HasKey(t => new { t.ExperienceId, t.PersonId });

            builder.Entity<Experiences_Persons>()
                .HasOne(ep => ep.Experience)
                .WithMany(e => e.Experiences_Persons)
                .HasForeignKey(ep => ep.ExperienceId);

            builder.Entity<Experiences_Persons>()
                .HasOne(ep => ep.Person)
                .WithMany(p => p.Experiences_Persons)
                .HasForeignKey(ep => ep.PersonId);
        }
    }
}
