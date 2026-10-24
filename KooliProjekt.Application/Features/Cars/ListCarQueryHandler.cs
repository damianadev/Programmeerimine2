using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Cars;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Cars
{
    public class ListCarQueryHandler : IRequestHandler<ListCarQuery, OperationResult<PagedResult<CarDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListCarQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<CarDto>>> Handle(ListCarQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<CarDto>>();
            result.Value = await _dbContext.Cars
                .AsNoTracking()
                .OrderByDescending(list => list.id)
                .Select(list => new CarDto
                {
                    id = list.id,
                    ReservationNo = list.ReservationNo,
                    CarModelId = list.CarModelId,
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
