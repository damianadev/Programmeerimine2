using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Cars
{
    public class SaveCarCommand : IRequest<OperationResult>, ITransactional
    {
        public int id { get; set; }
        public bool ReservationNo { get; set; }
        public int CarModelId { get; set; }
    }
}
