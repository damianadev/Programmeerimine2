using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Reservations;
using MediatR;


namespace KooliProjekt.Application.Features.Reservations
{
    public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, Reservation>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetReservationQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Reservation> Handle(GetReservationQuery request, CancellationToken cancellationToken)
        {
            var list = await _dbContext.Reservations.FindAsync(request.Id, cancellationToken);

            return list;
        }
    }
}
