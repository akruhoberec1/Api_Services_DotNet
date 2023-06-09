﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_BestPractices.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Abrv { get; set; } = string.Empty;

        public int MakeId { get; set; }
        [ForeignKey("MakeId")]
        public VehicleMake? VehicleMakes { get; set; }

    }
}
