using FluentValidation;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ad boş geçilemez");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(x => x.DateOfBirth).NotEmpty().WithMessage("Doğum Tarihi boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail Boş geçilemez");
            RuleFor(x => x.TcNo).NotEmpty().WithMessage("Tc boş geçilemez");
            RuleFor(x => x.DateOfBirth).LessThan(DateTime.Now);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.TcNo).Length(11);
                }
    }
}
