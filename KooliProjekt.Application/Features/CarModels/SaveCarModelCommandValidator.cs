using FluentValidation;
using KooliProjekt.Application.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.CarModels
{
    public class SaveCarModelCommandValidator : AbstractValidator<SaveCarModelCommand>
    {
        public SaveCarModelCommandValidator(ApplicationDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required.")
                .MaximumLength(25)
                .WithMessage("Name must not exceed 25 characters.");

            RuleFor(x => x.CarManufacturerId)
                .GreaterThan(0).WithMessage("CarManufacturerId must be greater than 0.")
                .MustAsync(async (id, cancellationToken) =>
                    await dbContext.CarManufacturers
                        .AnyAsync(x => x.Id == id, cancellationToken)).WithMessage("The specified car manufacturer does not exist.");

            RuleFor(x => x.TimePrice)
                .GreaterThan(0).WithMessage("TimePrice must be greater than 0.");

            RuleFor(x => x.KmPrice)
                .GreaterThanOrEqualTo(0).WithMessage("KmPrice must be greater than or equal to 0.");
        }
    }
}
