using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Areas.Identity.Data;
using Pharmacy.Models;

namespace Pharmacy.Data
{
    public class ApplicationDbContext : IdentityDbContext<PharmacyUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Inventory> Inventory { get; set; } = default!;
        public DbSet<Pet> Pet { get; set; } = default!;
        public DbSet<Prescription> Prescription { get; set; } = default!;
        public DbSet<Report> Report { get; set; } = default!;
        public DbSet<Appointment> Appointment { get; set; }

        // creating Roles for the application 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PharmacyUser>().HasData(
                new PharmacyUser
                {
                    Id = 1,
                    UserName = "doctor@gmail.com",
                    NormalizedUserName = "DOCTOR@GMAIL.COM",
                    Email = "doctor@gmail.com",
                    NormalizedEmail = "DOCTOR@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<PharmacyUser>().HashPassword(null, "Pharma123!"),
                    SecurityStamp = string.Empty,
                },
                new PharmacyUser
                {
                    Id = 2,
                    UserName = "Nurse@gmail.com",
                    NormalizedUserName = "NURSE@GMAIL.COM",
                    Email = "Nurse@gmail.com",
                    NormalizedEmail = "NURSE@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<PharmacyUser>().HashPassword(null, "Pharma123!"),
                    SecurityStamp = string.Empty,
                },
                new PharmacyUser
                {
                    Id = 3,
                    UserName = "Patient@gmail.com",
                    NormalizedUserName = "PATIENT@GMAIL.COM",
                    Email = "Patient@gmail.com",
                    NormalizedEmail = "PATIENT@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<PharmacyUser>().HashPassword(null, "Pharma123!"),
                    SecurityStamp = string.Empty,
                },
                new PharmacyUser
                {
                    Id = 4,
                    UserName = "Pharmacist@gmail.com",
                    NormalizedUserName = "PHARMACIST@GMAIL.COM",
                    Email = "Pharmacist@gmail.com",
                    NormalizedEmail = "PHARMACIST@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<PharmacyUser>().HashPassword(null, "Pharma123!"),
                    SecurityStamp = string.Empty,
                }
             );

            builder.Entity<IdentityRole<int>>().HasData(
                 new IdentityRole<int>
                 {
                     Id = 1,
                     Name = "Doctor",
                     NormalizedName = "DOCTOR"
                 },
                 new IdentityRole<int>
                 {
                     Id = 2,
                     Name = "Nurse",
                     NormalizedName = "NURSE"
                 },
                 new IdentityRole<int>
                 {
                     Id = 3,
                     Name = "Patient",
                     NormalizedName = "PATIENT"
                 },
                 new IdentityRole<int>
                 {
                     Id = 4,
                     Name = "Pharmacist",
                     NormalizedName = "PHARMACIST"
                 }
                );

            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>
                {
                    RoleId = 1,
                    UserId = 1
                },
                new IdentityUserRole<int>
                {
                    RoleId = 2,
                    UserId = 2
                },
               new IdentityUserRole<int>
               {
                   RoleId = 3,
                   UserId = 3
               },
              new IdentityUserRole<int>
              {
                  RoleId = 4,
                  UserId = 4
              }
             );
        }
    }
}