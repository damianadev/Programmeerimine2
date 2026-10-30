using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.CarModels
{
    public class SaveCarModelCommand : IRequest<OperationResult>, ITransactional
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int CarManufacturerId { get; set; }
        public decimal TimePrice { get; set; }
        public decimal KmPrice { get; set; }
    }
}
