using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Features.Cars
{
    public class SaveCarCommandHandler : IRequestHandler<SaveCarCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveCarCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveCarCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var userExists = await _dbContext.Cars
                .AnyAsync(user => user.id == request.id);
            if (!userExists)
            {
                return result.AddPropertyError("Id", "Cannot find car with ID " + request.id);
            }

            var list = new Car();

            if (request.id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<Car>(request.id);
            }

            list.id = request.id;
            list.ReservationNo = request.ReservationNo;
            list.CarModelId = request.CarModelId;


            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
