using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.Identity.Client;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class DeleteCarManufacturerCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
    }
}
