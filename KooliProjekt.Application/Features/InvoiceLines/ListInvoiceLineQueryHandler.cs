using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.InvoiceLines;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.InvoiceLines
{
    public class ListInvoiceLineQueryHandler : IRequestHandler<ListInvoiceLineQuery, OperationResult<PagedResult<InvoiceLineDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListInvoiceLineQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<InvoiceLineDto>>> Handle(ListInvoiceLineQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<InvoiceLineDto>>();
            result.Value = await _dbContext.InvoiceLines
                .AsNoTracking()
                .OrderByDescending(list => list.id)
                .Select(list => new InvoiceLineDto
                {
                    id = list.id,
                    Description = list.Description,
                    Total = list.Total,
                    ReservationId = list.ReservationId,
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
