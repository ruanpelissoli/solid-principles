using solid_principles.DIP.Solution;
using solid_principles.DIP.Solution.Interfaces;

namespace solid_principles.DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService(new EmailService(), new CustomerRepository());
            customerService.AddCustomer(new Customer());

            var specialCustomerService = new CustomerService(new EmailService(), new SpecialCustomerRepository());
            specialCustomerService.AddCustomer(new Customer());
        }
    }

    public class SpecialCustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            // new implementation
        }
    }
}
