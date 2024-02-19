using Dernek_Takip_Projesi.Data_Access_Layer.Entities;
using FluentValidation;

namespace Dernek_Takip_Projesi.Business_Layer.Validations
{
    public class RevenueValidator : AbstractValidator<Revenue>
    {
        public RevenueValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage("Lütfen ID değerini giriniz.");
            RuleFor(r => r.Id).LessThan(10000000000).WithMessage("TCKN/VKN eksik girildi.");
            RuleFor(r=>r.Fee).NotEmpty().WithMessage("Lütfen UCRET değerini giriniz.");
            RuleFor(r=>r.Fee).LessThan(2147483640).WithMessage("Maksimum UCRET değerine ulaştınız.");
        }
    }
}
