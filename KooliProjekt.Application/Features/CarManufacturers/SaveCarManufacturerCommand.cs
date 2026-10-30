using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class SaveCarManufacturerCommand : IRequest<OperationResult>, ITransactional
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}
