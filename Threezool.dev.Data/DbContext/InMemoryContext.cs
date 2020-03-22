using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Threezool.dev.Data.Models;
using Threezool.dev.Data.Seed;

namespace Threezool.dev.Data.DbContext
{
    public class InMemoryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }

        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().HasData(ProjectSeed.GetProjectSeedData());
            
            modelBuilder.Entity<Skill>().HasData(ProjectSeed.GetProjectSeedData());
        }
    }
}