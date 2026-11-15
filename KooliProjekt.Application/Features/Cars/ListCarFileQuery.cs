using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Cars
{
    public class ListCarFileQuery : IRequest<OperationResult<List<Stream>>>
    {
        public int Id { get; set; }
    }
}
