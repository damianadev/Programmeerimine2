using FluentValidation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KooliProjekt.Application.Features.Cars
{
    public class AddCarFileCommandValidator : AbstractValidator<AddCarFileCommand>
    {
        public AddCarFileCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(1).WithMessage("Id must be greater than or equal to 1.");

            RuleFor(x => x.FileName)
                .NotEmpty()
                .MaximumLength(255)
                .Must(name => name.IndexOfAny(
                    Path.GetInvalidFileNameChars()) == -1).WithMessage("File name contains invalid characters.");

            RuleFor(x => x.InputStream)
                .NotNull().WithMessage("File is required.")
                .Must(stream => stream.CanRead).WithMessage("File stream must be readable.")
                .Must(stream => stream.Length > 0).WithMessage("File cannot be empty.");
        }
    }
}
