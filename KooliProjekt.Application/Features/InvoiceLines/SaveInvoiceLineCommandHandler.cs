using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.InvoiceLines
{
    public class SaveInvoiceLineCommandHandler : IRequestHandler<SaveInvoiceLineCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveInvoiceLineCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveInvoiceLineCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var userExists = await _dbContext.InvoiceLines
                .AnyAsync(user => user.Id == request.Id);
            if (!userExists)
            {
                return result.AddPropertyError("Id", "Cannot find invoice line with ID " + request.Id);
            }

            var list = new InvoiceLine();

            if (request.Id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<InvoiceLine>(request.Id);
            }

            list.Id = request.Id;
            list.Description = request.Description;
            list.Total = request.Total;
            list.ReservationId = request.ReservationId;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
