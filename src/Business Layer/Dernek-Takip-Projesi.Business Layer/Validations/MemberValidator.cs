using Dernek_Takip_Projesi.Data_Access_Layer.Entities;
using FluentValidation;
//FluentValidation kütüphanesini ekledim.

namespace Dernek_Takip_Projesi.Business_Layer.Validations
{
    public class MemberValidator : AbstractValidator<Member> //Member class'ına göre doğrulama yapacağını belirttim.
    {
        public MemberValidator()
        {
            //Constructor içerisindeki kuralları tanımladım.
            RuleFor(m => m.Id).NotEmpty().WithMessage("Lütfen ID alanını giriniz.");
            RuleFor(m => m.Name).NotEmpty().WithMessage("Lütfen İSİM alanını giriniz.");
            RuleFor(m => m.Surname).NotEmpty().WithMessage("Lütfen SOYİSİM alanını giriniz.");
            RuleFor(m => m.Age).NotEmpty().WithMessage("Lütfen YAŞ  alanını giriniz.");
            RuleFor(m => m.EmailAddress).NotEmpty().WithMessage("Lütfen E-POSTA alanını giriniz.");
            RuleFor(m => m.EmailAddress).EmailAddress().WithMessage("Lütfen E-POSTA formatında giriş yapınız.");
            RuleFor(m => m.PhoneNumber).NotEmpty().WithMessage("Lütfen TELEFON NUMARASI alanını giriniz.");
            RuleFor(m => m.Gender).NotEmpty().WithMessage("Lütfen CİNSİYET alanını giriniz.");
            //İlgili kuralları tanımladıktan sonra fırlatılması gerekilen mesajları belirttim.
        }
    }
}
