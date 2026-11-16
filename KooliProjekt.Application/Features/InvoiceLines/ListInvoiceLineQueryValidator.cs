using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace KooliProjekt.Application.Features.InvoiceLines
{
    public class ListInvoiceLineQueryValidator : AbstractValidator<ListInvoiceLineQuery>
    {
        public ListInvoiceLineQueryValidator()
        {
            RuleFor(x => x.Page).GreaterThanOrEqualTo(1);
            RuleFor(x => x.PageSize).GreaterThanOrEqualTo(1);
        }
    }
}
