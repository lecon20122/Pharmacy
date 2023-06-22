using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Areas.Identity.Data;
using Pharmacy.Models;

namespace Pharmacy.Data
{
    public class ApplicationDbContext : IdentityDbContext<PharmacyUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Inventory> Inventory { get; set; } = default!;
        public DbSet<Pet> Pet { get; set; } = default!;
    }
}