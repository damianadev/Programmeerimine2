using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Invoices;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Invoices
{
    public class ListInvoiceQueryHandler : IRequestHandler<ListInvoiceQuery, IEnumerable<Invoice>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListInvoiceQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Invoice>> Handle(ListInvoiceQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Invoices.ToListAsync(cancellationToken);

            return result;
        }
    }
}
