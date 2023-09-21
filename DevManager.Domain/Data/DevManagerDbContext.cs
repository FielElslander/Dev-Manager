using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DevManager.Domain.Entities;
using Task = DevManager.Domain.Entities.Task;
using Microsoft.Extensions.Configuration;

namespace DevManager.Domain.Data
{
    public partial class DevManagerDbContext : DbContext
    {
        public DevManagerDbContext()
        {
        }

        public DevManagerDbContext(DbContextOptions<DevManagerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerProject> CustomerProjects { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectTask> ProjectTasks { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<TeamProject> TeamProjects { get; set; } = null!;
        public virtual DbSet<TeamUser> TeamUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerProject>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProjectID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TaskDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.TeamId)
                    .ValueGeneratedNever()
                    .HasColumnName("TeamID");

                entity.Property(e => e.TeamDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TeamProject>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ProjectId).HasColumnName("projectID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");
            });

            modelBuilder.Entity<TeamUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
