﻿namespace solid_principles.SRP.Solution
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
            emailService.Enviar("empresa@empresa.com", customer.Email.Address, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
