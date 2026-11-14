using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Infrastructure.Files;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Cars
{
    public class DeleteCarFileCommandHandler : IRequestHandler<DeleteCarFileCommand, OperationResult> 
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileClient _fileClient;

        public DeleteCarFileCommandHandler(ApplicationDbContext context, IFileClient fileClient)
        {
            _context = context;
            _fileClient = fileClient;
        }

        public async Task<OperationResult> Handle(DeleteCarFileCommand request, CancellationToken cancellationToken)
        {
            await _fileClient.Delete(request.FileName);

            return new OperationResult();
        }
    }
}
