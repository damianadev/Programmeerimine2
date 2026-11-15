using FluentValidation;
using KooliProjekt.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KooliProjekt.Application.Features.Customers
{
    public class SaveCustomerCommandValidator : AbstractValidator<SaveCustomerCommand>
    {
        public SaveCustomerCommandValidator(ApplicationDbContext dbContext)
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.CustomerName)
                .NotEmpty().WithMessage("Customer name is required.")
                .MaximumLength(25).WithMessage("Customer name must not exceed 25 characters.")
                .Custom((name, context) =>
                {
                    var command = context.InstanceToValidate;

                    var existingCustomer = dbContext.Customers
                        .Any(c => c.CustomerName == name &&
                                  c.Id != command.Id);

                    if (existingCustomer)
                    {
                        context.AddFailure("CustomerName","A customer with the same name already exists.");
                    }
                });

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .MaximumLength(255).WithMessage("Email must not exceed 255 characters.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MaximumLength(255).WithMessage("Password must not exceed 255 characters.");
        }
    }
}
