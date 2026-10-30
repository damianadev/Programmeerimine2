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

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class DeleteCarManufacturerCommandHandler : IRequestHandler<DeleteCarManufacturerCommand, OperationResult>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteCarManufacturerCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult> Handle(DeleteCarManufacturerCommand request, CancellationToken cancellationToken)
        {
            await _dbContext.CarManufacturers
                .Where(list => list.id == request.Id)
                .ExecuteDeleteAsync();

            return new OperationResult();
        }
    }
}
