using ActiveUp.Net.Mail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public interface IEmailSender
    {
        void SendEmail(Message message, string caso);
        Task SendEmailAsync(Message message, string caso);
        
    }
}
