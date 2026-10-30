using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Invoices
{
    public class SaveInvoiceCommand : IRequest<OperationResult>, ITransactional
    {
        public int id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueTime { get; set; }
        public bool Paid { get; set; }
        public int CustomerId { get; set; }
    }
}
