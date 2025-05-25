using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace UCK.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public string Get() =>
            "Welcome to UCK API! This is the home controller.";
    }
}
