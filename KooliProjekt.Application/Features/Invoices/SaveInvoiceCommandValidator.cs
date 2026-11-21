using FluentValidation;
using KooliProjekt.Application.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Features.Invoices
{
    public class SaveInvoiceCommandValidator : AbstractValidator<SaveInvoiceCommand>
    {
        public SaveInvoiceCommandValidator(ApplicationDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.InvoiceDate)
                .NotEqual(default(DateTime));

            RuleFor(x => x.DueTime)
                .NotEqual(default(DateTime))
                .GreaterThanOrEqualTo(x => x.InvoiceDate).WithMessage("DueTime must not be earlier than InvoiceDate.");

            RuleFor(x => x.UserId)
                .GreaterThan(0)
                .MustAsync(async (id, cancellationToken) =>
                    await dbContext.Users.AnyAsync(x => x.Id == id, cancellationToken)).WithMessage("The specified user does not exist.");
        }
    }
}
