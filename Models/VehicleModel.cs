using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_BestPractices.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Abrv { get; set; } = string.Empty;
        [ForeignKey("VehicleMake")]
        public int MakeId { get; set; }

        public VehicleMake? VehicleMakes { get; set; } 

    }
}
