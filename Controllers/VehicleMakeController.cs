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
            return await _vehicleService.GetAllMakes();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleMake>?> GetSingleMake(int id)
        {
            var result = await _vehicleService.GetSingleMake(id);
            if (result is null)
                return NotFound("Make not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<VehicleMake>> AddMake(VehicleMake make)
        {
            var result = await _vehicleService.AddMake(make);
            if (result is null)
                return NotFound("Make not found.");

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<VehicleMake>?> UpdateSingleMake(int id, VehicleMake request)
        {
            var result = await _vehicleService.UpdateSingleMake(id, request);
            if (result is null)
                return NotFound("Make not found.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<VehicleMake>>> DeleteMake(int id)
        {
            var result = await _vehicleService.DeleteMake(id);
            if (result is null)
                return NotFound("Make not found.");

            return Ok(result);
        }

    }
}
