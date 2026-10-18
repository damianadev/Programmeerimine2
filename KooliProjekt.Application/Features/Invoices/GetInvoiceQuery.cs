using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.Invoices
{
    public class GetInvoiceQuery : IRequest<Invoice>
    {
        public int Id { get; set; }
    }
}
