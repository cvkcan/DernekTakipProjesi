using Dernek_Takip_Projesi.Data_Access_Layer.Entities;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business
{
    public class EmailController
    {
        private readonly Email _email;
        //Dependency Injection (DI) kullandım.

        public EmailController(Email email)
        {
            _email = email;
            //DI'yı constructor'da tanımladım.
        }

        public string errorMessage = string.Empty;
        public bool SendMail(string subject, string body, string cc, List<string> mailAdress)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = _email.Host;
                smtp.Port = _email.Port;
                smtp.EnableSsl = true;
                //Email sınıfındaki verileri kullanarak ilgili alanları doldurdum.
                NetworkCredential credential = new NetworkCredential(_email.EmailAddress, _email.EmailPassword);
                smtp.Credentials = credential;
                //Credential için gerekli olan uygulama şifresini verdim.
                foreach (var item in mailAdress)
                {
                    MailAddress from = new MailAddress(_email.EmailAddress, "Sagolayanlar Derneği");
                    MailAddress to = new MailAddress(item.ToString());
                    MailMessage message = new MailMessage(from, to);
                    if (subject != null && subject != "")
                    {
                        message.Subject = subject;
                        message.Body = body;
                    }
                    else
                    {
                        message.Subject = _email.Subject;
                        message.Body = _email.Body;
                    }
                    if (cc != null && cc != "")
                    {
                        MailAddress bcc = new MailAddress(cc);
                        message.Bcc.Add(bcc);
                    }
                    //Gelen verilerin doluluğuna göre default verileri kullanmasını sağladım.
                    message.IsBodyHtml = true;
                    smtp.Send(message);
                }
                return true;
            }
            catch (System.Exception ex)
            {
                errorMessage = ex.Message;
                return false;
                //Hata durumunu kontrol ettim.
            }
        }

    }
}
