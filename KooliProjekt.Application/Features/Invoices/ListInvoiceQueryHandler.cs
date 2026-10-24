using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Invoices;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Invoices
{
    public class ListInvoiceQueryHandler : IRequestHandler<ListInvoiceQuery, OperationResult<PagedResult<InvoiceDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListInvoiceQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<InvoiceDto>>> Handle(ListInvoiceQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<InvoiceDto>>();
            result.Value = await _dbContext.Invoices
                .AsNoTracking()
                .OrderByDescending(list => list.id)
                .Select(list => new InvoiceDto
                {
                    id = list.id,
                    InvoiceDate = list.InvoiceDate,
                    DueTime = list.DueTime,
                    Paid = list.Paid,
                    CustomerId = list.CustomerId,
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
