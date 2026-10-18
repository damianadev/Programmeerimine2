using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Cars;
using MediatR;

namespace KooliProjekt.Application.Features.CarModels
{
    public class GetCarModelQueryHandler : IRequestHandler<GetCarModelQuery, CarModel>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetCarModelQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CarModel> Handle(GetCarModelQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.CarModels.FindAsync(request.Id, cancellationToken);

            return list;
        }
    }
}
