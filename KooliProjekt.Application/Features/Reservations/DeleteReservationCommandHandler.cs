using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Reservations
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteReservationCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
        {
            await _dbContext.Reservations
                .Where(list => list.Id == request.Id)
                .ExecuteDeleteAsync();

            return new OperationResult();
        }
    }
}
