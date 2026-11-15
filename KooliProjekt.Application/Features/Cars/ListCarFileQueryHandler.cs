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
    public class ListCarFileQueryHandler : IRequestHandler<ListCarFileQuery ,OperationResult<List<Stream>>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileClient _fileClient;

        public ListCarFileQueryHandler(ApplicationDbContext context, IFileClient fileClient)
        {
            _context = context;
            _fileClient = fileClient;
        }

        public async Task<OperationResult<List<Stream>>> Handle(ListCarFileQuery request, CancellationToken cancellationToken)
        {
            var files = await _fileClient.List(request.Id);

            return new OperationResult<List<Stream>>(files);
        }
    }
}
