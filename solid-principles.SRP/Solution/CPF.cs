﻿namespace solid_principles.SRP.Solution
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
