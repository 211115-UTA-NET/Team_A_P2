using Microsoft.AspNetCore.Mvc;
using PhoenixTheatreAPI.Dtos;
using PhoenixTheatreAPI.Services;

namespace PhoenixTheatreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoenixTheatreController : ControllerBase
    {
        PhoenixTheatreService _service;

        public PhoenixTheatreController(PhoenixTheatreService service)
        {
            _service = service;
        }

        [HttpGet("customer")]
        public IEnumerable<Customer> GetCustomerByName(string firstName, string lastName)
        {
            var customer = _service.GetCustomerByName(firstName, lastName);
            return customer;
        }

    }
}
