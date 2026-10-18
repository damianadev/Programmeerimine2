using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.Reservations
{
    public class GetReservationQuery : IRequest<Reservation>
    {
        public int Id { get; set; }
    }
}
