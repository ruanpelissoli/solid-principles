﻿namespace solid_principles.DIP.Violation
{
    public class Cpf
    {
        public string Number { get; set; }

        public bool Validate()
        {
            return Number.Length == 11;
        }
    }
}
