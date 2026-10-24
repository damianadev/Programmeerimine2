using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.CarManufacturers;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class ListCarManufacturerQueryHandler : IRequestHandler<ListCarManufacturerQuery, OperationResult<PagedResult<CarManufacturerDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListCarManufacturerQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<CarManufacturerDto>>> Handle(ListCarManufacturerQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<CarManufacturerDto>>();
            result.Value = await _dbContext.CarManufacturers
                .AsNoTracking()
                .OrderByDescending(list => list.id)
                .Select(list => new CarManufacturerDto
                {
                    id = list.id,
                    Name = list.Name,
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
