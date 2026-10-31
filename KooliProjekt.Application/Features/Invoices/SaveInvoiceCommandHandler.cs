using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Invoices
{
    public class SaveInvoiceCommandHandler : IRequestHandler<SaveInvoiceCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveInvoiceCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveInvoiceCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var userExists = await _dbContext.Invoices
                .AnyAsync(user => user.Id == request.Id);
            if (!userExists)
            {
                return result.AddPropertyError("Id", "Cannot find invoice with ID " + request.Id);
            }

            var list = new Invoice();

            if (request.Id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<Invoice>(request.Id);
            }

            list.Id = request.Id;
            list.InvoiceDate = request.InvoiceDate;
            list.DueTime = request.DueTime;
            list.Paid = request.Paid;
            list.CustomerId = request.CustomerId;


            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
