namespace Pharmacy.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public string File { get; set; }
    }
}
