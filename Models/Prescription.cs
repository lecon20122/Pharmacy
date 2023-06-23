namespace Pharmacy.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; }
        public string Dose { get; set; }
        public string Duration { get; set; }
        public int PetId { get; set; }
        public Pet? Pet { get; set; }
        public bool Status { get; set; }
    }
}
