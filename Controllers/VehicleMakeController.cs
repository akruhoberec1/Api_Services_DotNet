using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApi_BestPractices.Models;

namespace WebApi_BestPractices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleMakeController : ControllerBase
    {
        private static List<VehicleMake> makes = new List<VehicleMake>
            {
                new VehicleMake
                { 
                    Id = 1, 
                    Name = "Volkswagen", 
                    Abrv = "VW"
                },
                new VehicleMake
                {
                    Id = 2,
                    Name = "Bayerische Motoren Werke",
                    Abrv = "BMW"
                },
            };
        [HttpGet]
        public async Task<ActionResult<List<VehicleMake>>> GetAllMakes()
        {
            return Ok(makes);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<List<VehicleMake>>> GetSingleMake(int id)
        {
            var make = makes.Find(x => x.Id == id);
            return Ok(make);
        }

    }
}
