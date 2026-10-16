using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.CarManufacturers;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class ListCarManufacturerQueryHandler : IRequestHandler<ListCarManufacturerQuery, IEnumerable<CarManufacturer>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListCarManufacturerQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<CarManufacturer>> Handle(ListCarManufacturerQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.CarManufacturers.ToListAsync(cancellationToken);

            return result;
        }
    }
}
