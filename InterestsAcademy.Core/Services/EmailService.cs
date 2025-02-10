using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;

using InterestsAcademy.Common;
using MailKit.Security;
using System.Security.Authentication;


namespace InterestsAcademy.Core.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailConfig emailConfig;

        public EmailService(EmailConfig emailConfiguration)
        {
            this.emailConfig = emailConfiguration;
        }

        public async Task SendEmailAsync(SendMessageQueryModel email)
        {
            var mailMessage = CreateEmailMessage(email);
            await SendAsync(mailMessage);
        }

        private MimeMessage CreateEmailMessage(SendMessageQueryModel message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(null, message.From));
            emailMessage.To.Add(new MailboxAddress(null, emailConfig.UserName));
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = $"{message.From}: {message.Content}" };

            return emailMessage;
        }
        private async Task SendAsync(MimeMessage mailMessage)
        {

            using (var client = new SmtpClient())
            {
                try
                {
                    client.CheckCertificateRevocation = false;

                    await client.ConnectAsync(emailConfig.SmtpServer, emailConfig.Port);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    await client.AuthenticateAsync(emailConfig.UserName, emailConfig.Password);
                    await client.SendAsync(mailMessage);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await client.DisconnectAsync(true);
                    client.Dispose();
                }
            }
        }
    }
}
