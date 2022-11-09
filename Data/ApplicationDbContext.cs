using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenQuangKhaiBTH02.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenQuangKhaiBTH02.Models.Student> Student { get; set; } = default!;

        public DbSet<NguyenQuangKhaiBTH02.Models.Person> Person { get; set; } = default!;

        public DbSet<NguyenQuangKhaiBTH02.Models.Customer> Customer { get; set; } = default!;
    }
