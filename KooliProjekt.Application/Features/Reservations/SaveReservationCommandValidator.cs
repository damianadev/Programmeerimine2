using FluentValidation;
using KooliProjekt.Application.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.Reservations
{
    public class SaveReservationCommandValidator : AbstractValidator<SaveReservationCommand>
    {
        public SaveReservationCommandValidator(ApplicationDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.StartTime)
                .NotEqual(default(DateTime)).WithMessage("StartTime is required.");

            RuleFor(x => x.EndTime)
                .NotEqual(default(DateTime))
                .GreaterThan(x => x.StartTime).WithMessage("EndTime must be later than StartTime.");

            RuleFor(x => x.StartKm)
                .GreaterThanOrEqualTo(0).WithMessage("StartKm must be greater than or equal to 0.");

            RuleFor(x => x.EndKm)
                .GreaterThanOrEqualTo(x => x.StartKm).WithMessage("EndKm must be greater than or equal to StartKm.");

            RuleFor(x => x.TimePrice)
                .GreaterThanOrEqualTo(0).WithMessage("TimePrice must be greater than or equal to 0.");

            RuleFor(x => x.KmPrice)
                .GreaterThanOrEqualTo(0).WithMessage("KmPrice must be greater than or equal to 0.");

            RuleFor(x => x.CarId)
                .GreaterThan(0)
                .MustAsync(async (id, cancellationToken) =>
                    await dbContext.Cars.AnyAsync(x => x.Id == id, cancellationToken)).WithMessage("The specified car does not exist.");

            RuleFor(x => x.UserId)
                .GreaterThan(0)
                .MustAsync(async (id, cancellationToken) =>
                    await dbContext.Users.AnyAsync(x => x.Id == id, cancellationToken)).WithMessage("The specified user does not exist.");

        }
    }
}
