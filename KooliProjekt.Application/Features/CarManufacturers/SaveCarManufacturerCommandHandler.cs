using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class SaveCarManufacturerCommandHandler : IRequestHandler<SaveCarManufacturerCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveCarManufacturerCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveCarManufacturerCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var userExists = await _dbContext.CarManufacturers
                .AnyAsync(user => user.id == request.id);
            if (!userExists)
            {
                return result.AddPropertyError("Id", "Cannot find car manufacturer with ID " + request.id);
            }

            var list = new CarManufacturer();

            if (request.id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<CarManufacturer>(request.id);
            }

            list.id = request.id;
            list.Name = request.Name;


            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
