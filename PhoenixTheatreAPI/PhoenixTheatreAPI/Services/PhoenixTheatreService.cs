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
            return _context.FilmShowings.AsNoTracking().ToList();
        }

        public CustomerOrder GetOrderById(Guid orderId)
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

        public virtual Customer GetCustomerByUsername(string username)
        {
            var customer = new Customer();
            try
            {
                customer = _context.Customer.Where(x => x.Username == username).Single();
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

        public virtual Employee GetEmployeeByUsername(string username)
        {
            var employee = new Employee();
            try
            {
                employee = _context.Employee.Where(x => x.Username == username).Single();
            }
            catch (Exception ex)
            {
                return null;
            }
            return employee;
        }

        public Customer CreateCustomer(Customer newCustomer)
        {
            _context.Customer.Add(newCustomer);
            _context.SaveChanges();
            return newCustomer;
        }

        public Employee CreateEmployee(Employee newEmployee)
        {
            _context.Employee.Add(newEmployee);
            _context.SaveChanges();
            return newEmployee;
        }

        public CustomerOrder CreateOrder(CustomerOrder newOrder)
        {
            throw new NotImplementedException();
        }
    }
}
