using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Invoices;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Reservations
{
    public class ListReservationQueryHandler : IRequestHandler<ListReservationQuery, OperationResult<PagedResult<ReservationDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListReservationQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<ReservationDto>>> Handle(ListReservationQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<ReservationDto>>();
            result.Value = await _dbContext.Reservations
                .AsNoTracking()
                .OrderByDescending(list => list.id)
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
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
