using Microsoft.AspNetCore.Mvc;

namespace FlySmoother.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class StatusController : ControllerBase
    {
        [HttpGet]
        public string GetRootStatus()
        {
            return "I am healthy - TripPlanner";
        }
    }
}