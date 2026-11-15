using FluentValidation;
using KooliProjekt.Application.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.Cars
{
    public class SaveCarCommandValidator : AbstractValidator<SaveCarCommand>
    {
        public SaveCarCommandValidator(ApplicationDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.CarModelId)
                .GreaterThanOrEqualTo(1).WithMessage("CarModelId must be greater than or equal to 1.");

        }
    }
}
