using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Cars
{
    public class ListCarQueryHandler : IRequestHandler<ListCarQuery, IEnumerable<Car>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListCarQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable <Car>> Handle(ListCarQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Cars.ToListAsync(cancellationToken);

            return result;
        }
    }
}
