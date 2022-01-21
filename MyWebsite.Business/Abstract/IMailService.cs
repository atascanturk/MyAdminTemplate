using MyWebsite.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.Abstract
{
    public interface IMailService
    {
        void Send(EmailSendDto emailSendDto);
        void SendContactEmail(EmailSendDto emailSendDto);
        void SendLoginInfo(EmailSendDto emailSendDto);
    }
}
