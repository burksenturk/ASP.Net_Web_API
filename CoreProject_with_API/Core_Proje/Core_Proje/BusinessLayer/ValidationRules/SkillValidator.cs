using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SkillValidator : AbstractValidator<Skill>

    {
        public SkillValidator()
        {
            //Rulefor metodu ile form içerisinde değer girişinde yetki ve kontrol tanımlamaları yaparız
            RuleFor(x => x.Title).NotEmpty().WithMessage("Yetenek Başlığı Boş Geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Yetenek Değeri Boş Geçilemez");

            RuleFor(x => x.Title).MaximumLength(20).WithMessage("En fazla 20 karakter girmelisiniz");



        }
    }
}
