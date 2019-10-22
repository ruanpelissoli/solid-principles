using System;

namespace solid_principles.DIP.Solution
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime CreateDate { get; set; }

        public bool Validate()
        {
            return Email.Validate() && Cpf.Validar();
        }
    }
}