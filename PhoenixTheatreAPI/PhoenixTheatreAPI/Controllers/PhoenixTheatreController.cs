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

        [HttpGet("filmShowings")]
        public IEnumerable<FilmShowings> GetAllFilmShowings()
        {
            return _service.GetAllFilmShowings();
        }

        [HttpGet("orderId")]
        public ActionResult<CustomerOrder> GetOrderById(Guid orderId)
        {
            var order = _service.GetOrderById(orderId);

            if(order != null)
            {
                return order;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("customer")]
        public ActionResult<Customer> GetCustomerByName(string firstName, string lastName)
        {
            var customer = _service.GetCustomerByName(firstName, lastName);

            if(customer != null)
            {
                return customer;
            }
            else
            {
                return NotFound();
            }   
        }

        [HttpGet("invoiceLineItems")]
        public IEnumerable<InvoiceLineItem> GetInvoiceLineItems()
        {
            return _service.GetInvoiceLineItems();
        }

        [HttpGet("employee")]
        public ActionResult<Employee> GetEmployeeByName(string firstName, string lastName)
        {
            var employee = _service.GetEmployeeByName(firstName, lastName);
            if(employee != null)
            {
                return employee;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("{customer}")]
        public IActionResult CreateCustomer(Customer newCustomer)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{employee}")]
        public IActionResult CreateEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{order}")]
        public IActionResult CreateOrder(CustomerOrder newOrder)
        {
            throw new NotImplementedException();
        }
    }
}
