using FluentValidation;
using KooliProjekt.Application.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class SaveCarManufacturerCommandValidator : AbstractValidator<SaveCarManufacturerCommand>
    {
        public SaveCarManufacturerCommandValidator(ApplicationDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(25).WithMessage("Name must not exceed 25 characters.");
        }
    }
}
