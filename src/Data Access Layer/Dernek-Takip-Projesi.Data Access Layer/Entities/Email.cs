using Dernek_Takip_Projesi.Data_Access_Layer.Entities.Common;

namespace Dernek_Takip_Projesi.Data_Access_Layer.Entities
{
    public class Email : BaseEntity
    {
        static string _body = "Ödenmemiş aidatınız bulunmaktadır. Lütfen en kısa süre içerisinde ödeyiniz.";
        static string _subject = "Ödenmemiş Borç Hk.";
        public string EmailAddress { get; private set; } = "testprojectplans@gmail.com";
        public string EmailPassword { get; private set; } = "xxsg zxzg iihj iicm";
        public string Host { get; private set; } = "smtp.gmail.com";
        public int Port { get; private set; } = 587;
        public string Subject { get; set; } = _subject;
        public string Body { get; set; } = _body;
        public string To { get; set; }
        public string Cc { get; set; }
        public Email()
        {
                
        }
        //Default parametreleri class içerisine gömdüm.
    }
}
