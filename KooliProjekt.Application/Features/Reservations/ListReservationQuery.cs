using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.Reservations
{
    public class ListReservationQuery : IRequest<IEnumerable<Reservation>>
    {
    }
}
