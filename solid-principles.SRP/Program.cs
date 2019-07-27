using solid_principles.SRP.Solution;
using System;

namespace solid_principles.SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();

            var message = customerService.AddCustomer(new Customer
            {
                Id = 1,
                Name = "Customer Name",
                Cpf = new Cpf { Number = "99999999999" },
                Email = new Email { Address = "solid@principles.com" },
                CreatedAt = DateTime.Now
            });

            Console.WriteLine(message);
        }
    }
}
