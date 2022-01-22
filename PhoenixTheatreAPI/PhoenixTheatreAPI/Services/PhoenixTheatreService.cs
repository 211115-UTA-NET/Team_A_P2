using Microsoft.EntityFrameworkCore;
using PhoenixTheatreAPI.Data;
using PhoenixTheatreAPI.Dtos;

namespace PhoenixTheatreAPI.Services
{
    public class PhoenixTheatreService
    {
        private readonly PhoenixTheatreContext _context;
        public PhoenixTheatreService() { }
        public PhoenixTheatreService(PhoenixTheatreContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<FilmShowings> GetAllFilmShowings()
        {
            IEnumerable<FilmShowings> filmShowings = new List<FilmShowings>();
            try
            {
                filmShowings = _context.FilmShowings;
            }
            catch
            {
                throw new Exception();
            }
            return filmShowings;
        }

        public virtual CustomerOrder GetOrderById(Guid orderId)
        {
            var order = new CustomerOrder();
            try
            {
                order = _context.Orders.Where(x => x.OrderId == orderId).Single();
            }
            catch (Exception ex)
            {
                return null;
            }
            return order;
        }

        public virtual Customer GetCustomerByName(string firstName, string lastName)
        {
            var customer = new Customer();
            try
            {
                customer = _context.Customer.Where(x => x.FirstName == firstName && x.LastName == lastName).Single();
            }
            catch (Exception ex)
            {
                return null;
            }
            return customer;
        }

        public virtual Employee GetEmployeeByName(string firstName, string lastName)
        {
            var employee = new Employee();
            try
            {
                employee = _context.Employee.Where(x => x.FirstName == firstName && x.LastName == lastName).Single();
            }
            catch (Exception ex)
            {
                return null;
            }
            return employee;
        }

        public virtual IEnumerable<InvoiceLineItem> GetInvoiceLineItems()
        {
            return _context.InvoiceLineItem;
        }

        public Customer CreateCustomer(Customer newCustomer)
        {
            throw new NotImplementedException();
        }

        public Employee CreateEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        public CustomerOrder CreateOrder(CustomerOrder newOrder)
        {
            throw new NotImplementedException();
        }
    }
}
