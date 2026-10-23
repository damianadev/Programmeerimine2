using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Customers;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Customers
{
    public class ListCustomerQueryHandler : IRequestHandler<ListCustomerQuery, OperationResult<PagedResult<CustomerDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListCustomerQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<CustomerDto>>> Handle(ListCustomerQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<CustomerDto>>();
            result.Value = await _dbContext.Customers
                .AsNoTracking()
                .OrderByDescending(list => list.Id)
                .Select(list => new CustomerDto
                {
                    Id = list.Id,
                    CustomerName = list.CustomerName,
                    Email = list.Email,
                    LoggedIn = list.LoggedIn,
                    Password = list.Password,
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
