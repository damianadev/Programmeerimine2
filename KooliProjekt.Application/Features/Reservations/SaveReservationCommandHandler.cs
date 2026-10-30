using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Reservations
{
    public class SaveReservationCommandHandler : IRequestHandler<SaveReservationCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveReservationCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(SaveReservationCommand request, CancellationToken cancellationToken)
        {
            var result = new OperationResult();

            var userExists = await _dbContext.Reservations
                .AnyAsync(user => user.id == request.id);
            if (!userExists)
            {
                return result.AddPropertyError("Id", "Cannot find resrvation with ID " + request.id);
            }

            var list = new Reservation();

            if (request.id == 0)
            {
                _dbContext.Add(list);
            }
            else
            {
                list = await _dbContext.FindAsync<Reservation>(request.id);
            }

            list.id = request.id;
            list.StartTime = request.StartTime;
            list.EndTime = request.EndTime;
            list.StartKm = request.StartKm;
            list.EndKm = request.EndKm;
            list.TimePrice = request.TimePrice;
            list.KmPrice = request.KmPrice;
            list.CarId = request.CarId;
            list.CustomerId = request.CustomerId;

            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
