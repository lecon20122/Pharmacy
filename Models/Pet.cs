using Pharmacy.Areas.Identity.Data;

namespace Pharmacy.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Type { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Age { get; set; } = default!;
        public string Gender { get; set; } = default!;
        public List<Prescription>? Prescription { get; set; }
        public string Allergies { get; set; }
        public List<Report>? Report { get; set; }
        public PharmacyUser? User { get; set; }
        public int UserId { get; set; }
    }
}
