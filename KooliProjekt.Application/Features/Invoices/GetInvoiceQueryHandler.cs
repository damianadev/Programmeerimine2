using System;
using System.Linq;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Invoices
{
    public class GetInvoiceQueryHandler : IRequestHandler<GetInvoiceQuery, OperationResult<InvoiceDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetInvoiceQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<InvoiceDto>> Handle(GetInvoiceQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<InvoiceDto>();
            response.Value = await _dbContext.Invoices
                .AsNoTracking()
                .Where(list => list.id == request.Id)
                .Select(list => new InvoiceDto
                {
                    id = list.id,
                    InvoiceDate = list.InvoiceDate,
                    DueTime = list.DueTime,
                    Paid = list.Paid,
                    CustomerId = list.CustomerId
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
