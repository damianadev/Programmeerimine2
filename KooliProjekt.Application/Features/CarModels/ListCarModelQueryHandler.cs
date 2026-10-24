using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.CarModels;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.CarModels
{
    public class ListCarModelQueryHandler : IRequestHandler<ListCarModelQuery, OperationResult<PagedResult<CarModelDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListCarModelQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<CarModelDto>>> Handle(ListCarModelQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<CarModelDto>>();
            result.Value = await _dbContext.CarModels
                .AsNoTracking()
                .OrderByDescending(list => list.id)
                .Select(list => new CarModelDto
                {
                    id = list.id,
                    Name = list.Name,
                    CarManufacturerId = list.CarManufacturerId,
                    TimePrice = list.TimePrice,
                    KmPrice = list.KmPrice,
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
