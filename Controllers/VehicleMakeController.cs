using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApi_BestPractices.Services.VehicleServices;

namespace WebApi_BestPractices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleMakeController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;   

        public VehicleMakeController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

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
            var result = _vehicleService.UpdateSingleMake(id, request);
            if (result is null)
                return NotFound("Make not found.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<VehicleMake>>> DeleteMake(int id)
        {
            var result = _vehicleService.DeleteMake(id);
            if (result is null)
                return NotFound("Make not found.");

            return Ok(result);
        }

    }
}
