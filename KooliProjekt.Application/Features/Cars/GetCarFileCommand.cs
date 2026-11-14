using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Cars
{
    public class GetCarFileCommand : IRequest<OperationResult<Stream>>
    {
        public int Id { get; set; }
        public string FileName { get; set; }
    }
}
