using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        //Kurallar ctor icine yazilir.
        public CarValidator()
        {
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(2);
            RuleFor(p => p.ModelYear).GreaterThan(0);

            //olmayan bir kural yapmak icin:
            RuleFor(p => p.Description).Must(BileBaslasin).WithMessage("Açıklama B harfi ile başlamalı");
        }

        private bool BileBaslasin(string arg)
        {
            return arg.StartsWith("B");
        }
    }
}
