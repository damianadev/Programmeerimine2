using System;
using System.Linq;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class GetCarManufacturerQueryHandler : IRequestHandler<GetCarManufacturerQuery, OperationResult<CarManufacturerDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetCarManufacturerQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<CarManufacturerDto>> Handle(GetCarManufacturerQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<CarManufacturerDto>();
            response.Value = await _dbContext.CarManufacturers
                .AsNoTracking()
                .Where(list => list.id == request.Id)
                .Select(list => new CarManufacturerDto
                {
                    id = list.id,
                    Name = list.Name,
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
