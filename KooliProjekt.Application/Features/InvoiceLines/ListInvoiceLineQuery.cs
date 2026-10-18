using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.InvoiceLines
{
    public class ListInvoiceLineQuery : IRequest<IEnumerable<InvoiceLine>>
    {
    }
}
