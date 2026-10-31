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
                .AnyAsync(user => user.Id == request.Id);
            if (!userExists)
            {
                return result.AddPropertyError("Id", "Cannot find car model with ID " + request.Id);
            }

            var list = new CarModel();

            if (request.Id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<CarModel>(request.Id);
            }

            list.Id = request.Id;
            list.Name = request.Name;
            list.CarManufacturerId = request.CarManufacturerId;
            list.TimePrice = request.TimePrice;
            list.KmPrice = request.KmPrice;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
