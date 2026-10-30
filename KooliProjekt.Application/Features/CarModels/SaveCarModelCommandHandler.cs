using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.CarModels
{
    public class SaveCarModelCommandHandler : IRequestHandler<SaveCarModelCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveCarModelCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveCarModelCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var userExists = await _dbContext.CarModels
                .AnyAsync(user => user.id == request.id);
            if (!userExists)
            {
                return result.AddPropertyError("Id", "Cannot find car model with ID " + request.id);
            }

            var list = new CarModel();

            if (request.id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<CarModel>(request.id);
            }

            list.id = request.id;
            list.Name = request.Name;
            list.CarManufacturerId = request.CarManufacturerId;
            list.TimePrice = request.TimePrice;
            list.KmPrice = request.KmPrice;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
