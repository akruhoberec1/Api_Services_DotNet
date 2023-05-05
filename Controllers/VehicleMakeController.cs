using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_BestPractices.Models;

namespace WebApi_BestPractices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleMakeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllMakes()
        {
            var makes = new List<VehicleMake>
            {
                new VehicleMake{ Id = 1, Name = "Volkswagen", Abrv = "VW"}
            };
        }
    }
}
