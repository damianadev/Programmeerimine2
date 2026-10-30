using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Reservations
{
    public class SaveReservationCommand : IRequest<OperationResult>, ITransactional
    {
        public int id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal StartKm { get; set; }
        public decimal EndKm { get; set; }
        public decimal TimePrice { get; set; }
        public decimal KmPrice { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
    }
}
