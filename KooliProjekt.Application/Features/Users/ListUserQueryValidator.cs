using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace KooliProjekt.Application.Features.Users
{
    public class ListUserQueryValidator : AbstractValidator<ListUserQuery>
    {
        public ListUserQueryValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(1);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
