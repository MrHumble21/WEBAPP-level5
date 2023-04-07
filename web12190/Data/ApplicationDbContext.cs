using Microsoft.EntityFrameworkCore;
using web12190.Models;

namespace web12190.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Delivery> Assignments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Validation> Submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Assignments)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Departments)
                .WithOne(cw => cw.Category)
                .HasForeignKey(cw => cw.CategoryId);

            modelBuilder.Entity<Product>()
                .HasMany(s => s.Assignments)
                .WithOne(a => a.Product)
                .HasForeignKey(a => a.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(s => s.Departments)
                .WithOne(cw => cw.Product)
                .HasForeignKey(cw => cw.ProductId);

            modelBuilder.Entity<Department>()
                .HasOne(cw => cw.Submission)
                .WithOne(s => s.Department)
                .HasForeignKey<Validation>(s => s.DepartmentId);
        }
    }
}
