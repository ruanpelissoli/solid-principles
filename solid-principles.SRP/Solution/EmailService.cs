using System.Net.Mail;

namespace solid_principles.SRP.Solution
{
    public static class EmailService
    {
        public static void Enviar(string from, string to, string subject, string message)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = message;
            client.Send(mail);

            System.Console.WriteLine(message);
        }
    }
}
