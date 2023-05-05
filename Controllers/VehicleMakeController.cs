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
        public async Task<ActionResult<VehicleMake>> GetSingleMake(int id)
        {
            var make = makes.Find(x => x.Id == id);
            if (make is null)
                return NotFound("Sorry, this Vehicle Make cannot be found. :(");
            return Ok(make);
        }

        [HttpPost]
        public async Task<ActionResult<VehicleMake>> AddMake(VehicleMake make)
        {
            makes.Add(make);
            return Ok(make);    
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<VehicleMake>> UpdateSingleMake(int id, VehicleMake request)
        {
            var make = makes.Find(x => x.Id == id);
            if (make is null)
                return NotFound("Sorry, this Vehicle Make cannot be found. :(");

            make.Name = request.Name;   
            make.Abrv = request.Abrv;   

            return Ok(makes);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<VehicleMake>>> DeleteMake(int id)
        {
            var make = makes.Find(x => x.Id == id);
            if (make is null)
                return NotFound("Sorry, this Vehicle Make cannot be found. :(");

            makes.Remove(make);

            return Ok(makes);
        }

    }
}
