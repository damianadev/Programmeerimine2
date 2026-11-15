using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace KooliProjekt.Application.Features.CarModels
{
    public class ListCarModelQueryValidator : AbstractValidator<ListCarModelQuery>
    {
        public ListCarModelQueryValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(1);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
