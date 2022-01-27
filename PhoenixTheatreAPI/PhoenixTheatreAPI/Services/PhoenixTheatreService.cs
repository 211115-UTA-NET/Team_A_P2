using Microsoft.EntityFrameworkCore;
using PhoenixTheatre.DataInfrastructure;

namespace PhoenixTheatreAPI.Services
{
    public class PhoenixTheatreService
    {
        private readonly Team_A_P2Context _context;
        public PhoenixTheatreService() { }
        public PhoenixTheatreService(Team_A_P2Context context)
        {
            _context = context;
        }

        public virtual IEnumerable<FilmShowing> GetAllFilmShowings()
        {
            return _context.FilmShowings.AsNoTracking().ToList();
        }

        public CustomerOrder GetOrderById(Guid orderId)
        {
            var order = new CustomerOrder();
            try
            {
                order = _context.CustomerOrders.Where(x => x.OrderId == orderId).Single();
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
                customer = _context.Customers.Where(x => x.FirstName == firstName && x.LastName == lastName).Single();
            }
            catch (Exception ex)
            {
                return null;
            }
            return customer;
        }

        public virtual Customer GetCustomerByUsername(string username, string password)
        {
            var customer = new Customer();
            try
            {
                customer = _context.Customers.Where(x => x.Username == username && x.UserPassword == password).Single();
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
                employee = _context.Employees.Where(x => x.FirstName == firstName && x.LastName == lastName).Single();
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
                employee = _context.Employees.Where(x => x.Username == username).Single();
            }
            catch (Exception ex)
            {
                return null;
            }
            return employee;
        }

        public Customer CreateCustomer(Customer newCustomer)
        {
            _context.Customers.Add(new Customer
            {
                CustomerId = newCustomer.CustomerId,
                FirstName = newCustomer.FirstName,
                LastName = newCustomer.LastName,
                Username = newCustomer.Username,
                UserPassword = newCustomer.UserPassword
            });
            _context.SaveChanges();
            return newCustomer;
        }

        public Employee CreateEmployee(Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();
            return newEmployee;
        }

        public CustomerOrder CreateOrder(CustomerOrder newOrder)
        {
            throw new NotImplementedException();
        }
    }
}
