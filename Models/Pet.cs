namespace Pharmacy.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Prescription { get; set; }
        public string History { get; set; }
    }
}
