using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaApp.Data
{

    public class PizzeriaDbContext : IdentityDbContext<ApplicationUser>
    {

        public PizzeriaDbContext(DbContextOptions<PizzeriaDbContext> options) : base(options)
        {

        }

     

        public DbSet<Pizza> Pizza { get; private set; }
        //public DbSet<User> User { get; private set; }
        public DbSet<ApplicationUser> applicationUser { get; private set; }
        //public DbSet<CartItem> CartItem { get; private set; }
        public DbSet<Ingredients> Ingredients { get; private set; }
        public DbSet<CartItem> CartItem { get; private set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>().HasKey(x => x.CartItemId);
            base.OnModelCreating(modelBuilder);

        }

    }

    public class ApplicationUser : IdentityUser
    {
    }
}
