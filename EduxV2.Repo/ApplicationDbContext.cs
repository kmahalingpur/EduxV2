using EduxV2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduxV2.Repo
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityNextStep> ActivityNextSteps { get; set; }
        public DbSet<ActivitySource> ActivitySources { get; set; }
        public DbSet<ActivityStatus> ActivityStatuses { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<ClassLevel> ClassLevels { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Positiveness> Positiveness { get; set; }
        public DbSet<SchoolType> SchoolTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
