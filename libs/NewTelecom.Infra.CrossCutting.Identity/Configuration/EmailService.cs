﻿using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Web;

namespace NewTelecom.Infra.CrossCutting.Identity.Configuration
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Habilitar o envio de e-mail
            if (1 == 1)
            {
                var text = HttpUtility.HtmlEncode(message.Body);

                var msg = new MailMessage { From = new MailAddress("jose@lionssoftware.com.br", "Admin do Portal") };

                msg.To.Add(new MailAddress(message.Destination));
                msg.Subject = message.Subject;
                msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
                msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Html));

                var smtpClient = new SmtpClient("smtp.lionssoftware.com.br", Convert.ToInt32(587));
                var credentials = new NetworkCredential(ConfigurationManager.AppSettings[""], ConfigurationManager.AppSettings[""]);
                smtpClient.Credentials = credentials;
                smtpClient.EnableSsl = true;
                smtpClient.Send(msg);
            }

            return Task.FromResult(0);
        }
    }
}