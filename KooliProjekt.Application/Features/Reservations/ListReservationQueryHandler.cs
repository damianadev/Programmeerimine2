using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Reservations
{
    public class ListReservationQueryHandler : IRequestHandler<ListReservationQuery, IEnumerable<Reservation>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListReservationQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Reservation>> Handle(ListReservationQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Reservations.ToListAsync(cancellationToken);

            return result;
        }
    }
}
