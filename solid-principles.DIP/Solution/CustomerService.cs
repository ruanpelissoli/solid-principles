using solid_principles.DIP.Solution.Interfaces;

namespace solid_principles.DIP.Solution
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailService _emailService;

        public CustomerService(
            IEmailService emailService, 
            ICustomerRepository customerRepository)
        {
            _emailService = emailService;
            _customerRepository = customerRepository;
        }

        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate())
                return "Dados inválidos";

            _customerRepository.AddCustomer(customer);

            _emailService.Send("empresa@empresa.com", customer.Email.Address, "Bem-vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}