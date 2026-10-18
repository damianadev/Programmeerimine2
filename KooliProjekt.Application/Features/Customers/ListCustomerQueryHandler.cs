using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Customers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Customers
{
    public class ListCustomerQueryHandler : IRequestHandler<ListCustomerQuery, IEnumerable<Customer>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListCustomerQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Customer>> Handle(ListCustomerQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Customers.ToListAsync(cancellationToken);

            return result;
        }
    }
}
