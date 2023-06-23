namespace Pharmacy.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Type { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime Date { get; set; } = default!;
        public int? PetId { get; set; }
        public Pet? Pet { get; set; } = default!;
    }
}
