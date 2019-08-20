using System;
using System.Collections.Generic;
using System.Text;

namespace solid_principles.LSP.Solution.New
{
    public interface INotificationService
    {
        void SendText(string SmsNumber, string message);
        void SendEmail(string to, string from, string subject, string body);
    }

    public class SmtpNotificationService : INotificationService
    {
        public void SendEmail(string to, string from, string subject, string body)
        {
            // actually send email here
            // ...
        }

        public void SendText(string SmsNumber, string message)
        {
            throw new NotImplementedException();
        }
    }
}
