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

namespace KooliProjekt.Application.Features.CarModels
{
    public class GetCarModelQueryHandler : IRequestHandler<GetCarModelQuery, OperationResult<CarModelDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetCarModelQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<CarModelDto>> Handle(GetCarModelQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<CarModelDto>();
            response.Value = await _dbContext.CarModels
                .AsNoTracking()
                .Where(list => list.id == request.Id)
                .Select(list => new CarModelDto
                {
                    id = list.id,
                    Name = list.Name,
                    CarManufacturerId = list.CarManufacturerId,
                    TimePrice = list.TimePrice,
                    KmPrice = list.KmPrice,
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
