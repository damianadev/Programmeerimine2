using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.CarManufacturers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class GetCarManufacturerQueryHandler : IRequestHandler<GetCarManufacturerQuery, CarManufacturer>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetCarManufacturerQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CarManufacturer> Handle(GetCarManufacturerQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.CarManufacturers.FindAsync(request.Id, cancellationToken);

            return list;
        }
    }
}
