using Microsoft.AspNetCore.Identity;
using Pharmacy.Models;

namespace Pharmacy.Areas.Identity.Data;

// Add profile data for application users by adding properties to the PharmacyUser class
public class PharmacyUser : IdentityUser<int>
{
    public List<Pet>? Pet { get; set; }
}

