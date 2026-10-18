using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.CarModels;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.CarModels
{
    internal class ListCarModelQueryHandler : IRequestHandler<ListCarModelQuery, IEnumerable<CarModel>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListCarModelQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CarModel>> Handle(ListCarModelQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.CarModels.ToListAsync(cancellationToken);

            return result;
        }
    }
}
