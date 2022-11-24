using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RajinderpalsBooks.Models; // added using statement
namespace RajinderpalsBooks.DataAccess.Data // added DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }   // added this line
        public DbSet<CoverType> CoverType { get; set; }
    }
}
