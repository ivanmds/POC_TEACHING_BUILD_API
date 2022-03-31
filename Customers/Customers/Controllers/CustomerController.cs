using Microsoft.AspNetCore.Mvc;

namespace Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        // post => criar recurso do lado do servido
        
        
        [HttpGet]
        public  IActionResult Get()
        {

            return null;
        }

    }
}
