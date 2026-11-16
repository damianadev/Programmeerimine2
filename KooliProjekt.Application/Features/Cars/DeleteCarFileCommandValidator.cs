using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KooliProjekt.Application.Features.Cars
{
    public class DeleteCarFileCommandValidator : AbstractValidator<DeleteCarFileCommand>
    {
        public DeleteCarFileCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.FileName)
                .NotEmpty()
                .MaximumLength(255)
                .Must(name => name.IndexOfAny(
                    Path.GetInvalidFileNameChars()) == -1).WithMessage("File name contains invalid characters.");
        }
    }
}
