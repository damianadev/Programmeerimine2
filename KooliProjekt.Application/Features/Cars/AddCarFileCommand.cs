using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Cars
{
    public class AddCarFileCommand : IRequest<OperationResult>
    {
        public int Id { get; set; }
        // public string CarModel { get; set; }
        public string FileName { get; set; }
        public Stream InputStream { get; set; }
    }
}
