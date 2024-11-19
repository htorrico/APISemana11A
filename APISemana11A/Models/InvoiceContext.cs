using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APISemana11A.Models
{
    public class InvoiceContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; Database=APISemana12DB; Integrated Security=True;Trust Server Certificate=True ");
        }
    }
}
