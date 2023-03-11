using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SchoolProject.MVC.Models;

namespace SchoolProject.MVC.Data
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Database=School;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId, "IX_Projects_DepartmentId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.DepartmentId);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId, "IX_Students_DepartmentId");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.DepartmentId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
