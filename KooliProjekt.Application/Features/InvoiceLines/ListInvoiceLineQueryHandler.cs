using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.InvoiceLines;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.InvoiceLines
{
    public class ListInvoiceLineQueryHandler : IRequestHandler<ListInvoiceLineQuery, IEnumerable<InvoiceLine>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListInvoiceLineQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<InvoiceLine>> Handle(ListInvoiceLineQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.InvoiceLines.ToListAsync(cancellationToken);

            return result;
        }
    }
}
