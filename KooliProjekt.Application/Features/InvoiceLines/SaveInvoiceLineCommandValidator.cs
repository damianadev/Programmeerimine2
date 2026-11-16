using FluentValidation;
using KooliProjekt.Application.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.InvoiceLines
{
    public class SaveInvoiceLineCommandValidator : AbstractValidator<SaveInvoiceLineCommand>
    {
        public SaveInvoiceLineCommandValidator(ApplicationDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.Description)
                .NotEmpty().MaximumLength(255);

            RuleFor(x => x.Total)
                .GreaterThan(0);

            RuleFor(x => x.ReservationId)
                .GreaterThan(0)
                .MustAsync(async (id, cancellationToken) =>
                    await dbContext.Reservations.AnyAsync(x => x.Id == id, cancellationToken)).WithMessage("The specified reservation does not exist.");
        }
    }
}
