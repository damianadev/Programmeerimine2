using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Customers
{
    public class SaveCustomerCommandHandler : IRequestHandler<SaveCustomerCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveCustomerCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveCustomerCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var userExists = await _dbContext.Customers
                .AnyAsync(user => user.Id == request.Id);
            if (!userExists)
            {
                return result.AddPropertyError("Id", "Cannot find customer with ID " + request.Id);
            }

            var list = new Customer();

            if (request.Id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<Customer>(request.Id);
            }

            list.Id = request.Id;
            list.CustomerName = request.CustomerName;
            list.Email = request.Email;
            list.LoggedIn = request.LoggedIn;
            list.Password = request.Password;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
