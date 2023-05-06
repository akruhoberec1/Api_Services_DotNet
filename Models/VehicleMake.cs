using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_BestPractices.Models
{
    public class VehicleMake
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Abrv { get; set; } = string.Empty;
        
        public List<VehicleModel>? VehicleModels { get; set; }

    }
}
