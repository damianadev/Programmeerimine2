using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace KooliProjekt.Application.Features.Customers
{
    public class ListCustomerQueryValidator : AbstractValidator<ListCustomerQuery>
    {
        public ListCustomerQueryValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(1);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
