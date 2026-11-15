using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Files;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Cars
{
    public class GetCarFileCommandHandler : IRequestHandler<GetCarFileCommand, OperationResult<Stream>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileClient _fileClient;

        public GetCarFileCommandHandler(ApplicationDbContext context, IFileClient fileClient)
        {
            _context = context;
            _fileClient = fileClient;
        }
        public async Task<OperationResult<Stream>> Handle(GetCarFileCommand request, CancellationToken cancellationToken)
        {
            return new OperationResult<Stream>(await _fileClient.Get(request.Id, request.FileName));
        }
    }
}
