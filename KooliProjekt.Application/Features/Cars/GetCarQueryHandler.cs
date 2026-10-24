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

namespace KooliProjekt.Application.Features.Cars
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, OperationResult<CarDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetCarQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<CarDto>> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<CarDto>();
            response.Value = await _dbContext.Cars
                .AsNoTracking()
                .Where(list => list.id == request.Id)
                .Select(list => new CarDto
                {
                    id = list.id,
                    ReservationNo = list.ReservationNo,
                    CarModelId = list.CarModelId,
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
