using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Results;
using KooliProjekt.Application.Features.Customers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Customers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, OperationResult<CustomerDto> >
    {
        private readonly ApplicationDbContext _dbContext;

        public GetCustomerQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<CustomerDto>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<CustomerDto>();
            response.Value = await _dbContext.Customers
                .AsNoTracking()
                //.Include(list => list.CustomerName)
                //.Include(list => list.Email)
                //.Include(list => list.LoggedIn)
                //.Include(list => list.Password)
                .Where(list => list.Id == request.Id)
                .Select(list => new CustomerDto
                {
                    Id = list.Id,
                    CustomerName = list.CustomerName,
                    Email = list.Email,
                    LoggedIn = list.LoggedIn,
                    Password = list.Password,
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
