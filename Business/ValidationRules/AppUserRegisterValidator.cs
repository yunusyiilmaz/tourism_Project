﻿using Dto.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız");
            RuleFor(x => x.UserName).MaximumLength(28).WithMessage("Lütfen en fazla 28 karakter veri girişi yapınız");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor");
        }
    }
}
