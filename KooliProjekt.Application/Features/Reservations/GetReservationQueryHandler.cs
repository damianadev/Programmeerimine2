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

namespace KooliProjekt.Application.Features.Reservations
{
    public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, OperationResult<ReservationDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetReservationQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<ReservationDto>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<ReservationDto>();
            response.Value = await _dbContext.Reservations
                .AsNoTracking()
                .Where(list => list.id == request.Id)
                .Select(list => new ReservationDto
                {
                    id = list.id,
                    StartTime = list.StartTime,
                    EndTime = list.EndTime,
                    StartKm = list.StartKm,
                    EndKm = list.EndKm,
                    TimePrice = list.TimePrice,
                    KmPrice = list.KmPrice,
                    CarId = list.CarId,
                    CustomerId = list.CustomerId,
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
