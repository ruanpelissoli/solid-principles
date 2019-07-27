namespace solid_principles.SRP.Solution
{
    public class Email
    {
        public string Address { get; set; }

        public bool Validate()
        {
            return Address.Contains("@");
        }
    }
}
