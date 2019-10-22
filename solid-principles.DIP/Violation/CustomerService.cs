namespace solid_principles.DIP.Violation
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.Validate())
                return "Dados inválidos";

            var repo = new CustomerRepository();
            repo.AddCustomer(customer);

            var emailService = new EmailService();
            emailService.Send("empresa@empresa.com", customer.Email.Address, "Bem-vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
