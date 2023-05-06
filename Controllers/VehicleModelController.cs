using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_BestPractices.Services.VehicleServices;

namespace WebApi_BestPractices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;   

        public VehicleModelController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<VehicleModel>>> GetAllModels()
        {
            return await _vehicleService.GetAllModels();    
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleModel>?> GetSingleModel(int id)
        {
            var result = await _vehicleService.GetSingleModel(id);
            return result == null ? NotFound("ModelNotFound! :(") : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<VehicleModel>> AddModel(VehicleModel model)
        {
            var result = await _vehicleService.AddModel(model);
            return result == null ? NotFound("ModelNotFound! :(") : Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<VehicleModel>?> UpdateSingleModel(int id, VehicleModel request)
        {
            var result = await _vehicleService.UpdateSingleModel(id, request);
            return result == null ? NotFound("ModelNotFound! :(") : Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<VehicleModel>>>  DeleteModel(int id)
        {
            var result = await _vehicleService.DeleteModel(id);
            return result == null ? NotFound("ModelNotFound! :(") : Ok(result);
        }

    }
}
