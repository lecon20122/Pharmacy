using Pharmacy.Models;

namespace Pharmacy.Views.Reports
{
    public class CreateReportViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int PetId { get; set; }
        public Pet? Pet { get; set; }
        public IFormFile File { get; set; }
    }
}
