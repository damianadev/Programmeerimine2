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

namespace KooliProjekt.Application.Features.InvoiceLines
{
    public class GetInvoiceLineQueryHandler : IRequestHandler<GetInvoiceLineQuery, OperationResult<InvoiceLineDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetInvoiceLineQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<InvoiceLineDto>> Handle(GetInvoiceLineQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<InvoiceLineDto>();
            response.Value = await _dbContext.InvoiceLines
                .AsNoTracking()
                .Where(list => list.id == request.Id)
                .Select(list => new InvoiceLineDto
                {
                    id = list.id,
                    Description = list.Description,
                    Total = list.Total,
                    ReservationId = list.ReservationId,
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
