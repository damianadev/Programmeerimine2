using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.InvoiceLines
{
    public class SaveInvoiceLineCommand : IRequest<OperationResult>, ITransactional
    {
        public int id { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public int ReservationId { get; set; }
    }
}
