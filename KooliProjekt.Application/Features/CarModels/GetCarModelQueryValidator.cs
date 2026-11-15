using FluentValidation;
using KooliProjekt.Application.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.CarModels
{
    public class GetCarModelQueryValidator : AbstractValidator<GetCarModelQuery>
    {
        public GetCarModelQueryValidator(ApplicationDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");
        }
    }
}
