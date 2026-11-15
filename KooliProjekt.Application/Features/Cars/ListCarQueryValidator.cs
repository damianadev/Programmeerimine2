using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace KooliProjekt.Application.Features.Cars
{
    public class ListCarQueryValidator : AbstractValidator<ListCarQuery>
    {
        public ListCarQueryValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(1);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
