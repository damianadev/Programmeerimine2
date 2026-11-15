using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class ListCarManufacturerQueryValidator : AbstractValidator<ListCarManufacturerQuery>
    {
        public ListCarManufacturerQueryValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(1);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
