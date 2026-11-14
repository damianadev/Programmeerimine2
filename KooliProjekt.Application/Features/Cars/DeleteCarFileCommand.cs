using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using KooliProjekt.Application.Behaviors;

namespace KooliProjekt.Application.Features.Cars
{
    public class DeleteCarFileCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }
        public string FileName { get; set; }
    }
}
