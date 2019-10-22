namespace solid_principles.DIP.Violation
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
