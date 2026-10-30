using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.CarModels
{
    public class DeleteCarModelCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
    }
}
