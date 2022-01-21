using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Utilities.Security.Encryption;
using MyWebsite.Entities.Concrete;
using MyWebsite.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Concrete
{
    public class MailManager : IMailService
    {
        private readonly SmtpSettings _smtpSettings;
        UserManager<User> _userManager;

        public MailManager(IOptions<SmtpSettings> smtpSettings, UserManager<User> userManager)
        {
            _smtpSettings = smtpSettings.Value;
            _userManager = userManager;
        }

        public void Send(EmailSendDto emailSendDto)
        {
            var users = _userManager.Users.ToListAsync().Result;

            var password = EncrytionDecryptionHelper.DecryptCipherTextToPlainText(_smtpSettings.EncPassword);


            SmtpClient smtpClient = new SmtpClient()
            {
                Host = _smtpSettings.Server,
                Port = _smtpSettings.Port,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, password, "outlook.com"),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            foreach (var user in users)
            {
                MailMessage message = new MailMessage
                {
                    From = new MailAddress(_smtpSettings.SenderEmail),
                    Sender = new MailAddress(_smtpSettings.SenderEmail),
                    BodyEncoding = Encoding.UTF8,
                    To = { new MailAddress(user.Email) },
                    Subject = emailSendDto.Subject,
                    IsBodyHtml = true,// Belirli formatlara göre logo vs eklemek için
                    Body = emailSendDto.Message
                };

                try
                {
                    smtpClient.Send(message);
                }
                catch (Exception ex)
                {
                    var exMessage = ex.Message.ToString();
                }

            }

        }

        public void SendContactEmail(EmailSendDto emailSendDto)
        {
            throw new NotImplementedException();
        }

        public void SendLoginInfo(EmailSendDto emailSendDto)
        {
            throw new NotImplementedException();
        }
    }
}
