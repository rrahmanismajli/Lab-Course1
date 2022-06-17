using KlinikaProjekt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KlinikaProjekt.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Training_Doctor>().HasKey(am => new
            {
                am.DoctorId,
                am.TrainingId
            });

            modelBuilder.Entity<Training_Doctor>().HasOne(m => m.Training).WithMany(am => am.Training_Doctor).HasForeignKey(m => m.TrainingId);
            modelBuilder.Entity<Training_Doctor>().HasOne(m => m.Doctor).WithMany(am => am.Training_Doctor).HasForeignKey(m => m.DoctorId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Training_Doctor> Training_Doctors { get; set; }
        public DbSet<Department>Department { get; set; }
        public DbSet<Patient> Patient { get; set; }


        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<KlinikaProjekt.Models.Contact> Contact { get; set; }
        public DbSet<KlinikaProjekt.Models.News> News { get; set; }
        public DbSet<KlinikaProjekt.Models.Services> Services { get; set; }
        public DbSet<KlinikaProjekt.Models.Review> Review { get; set; }
    }
}
