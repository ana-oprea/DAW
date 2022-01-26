using ProiectASP.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext(DbContextOptions<ProiectContext> options) : base(options) { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many
            modelBuilder.Entity<Genre>()
                .HasMany(a => a.Movies)
                .WithOne(b => b.Genre);

            // One to One
            modelBuilder.Entity<Movie>()
                .HasOne(a => a.Detail)
                .WithOne(b => b.Movie)
                .HasForeignKey<Movie>(a => a.DetailId);

            // Many to Many
            modelBuilder.Entity<MovieActor>().HasKey(ma => new { ma.ActorId, ma.MovieId});

            modelBuilder.Entity<MovieActor>()
                .HasOne(a => a.Actor)
                .WithMany(b => b.MovieActors)
                .HasForeignKey(a => a.ActorId);

            modelBuilder.Entity<MovieActor>()
                .HasOne(a => a.Movie)
                .WithMany(b => b.MovieActors)
                .HasForeignKey(a => a.MovieId);

            base.OnModelCreating(modelBuilder);
        }

    }
}

