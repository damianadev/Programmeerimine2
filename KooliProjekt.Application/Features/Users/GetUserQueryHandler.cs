using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Results;
using KooliProjekt.Application.Features.Users;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, OperationResult<UserDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetUserQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var response = new OperationResult<UserDto>();
            response.Value = await _dbContext.Users
                .AsNoTracking()
                //.Include(list => list.UserName)
                //.Include(list => list.Email)
                //.Include(list => list.IsAdmin)
                //.Include(list => list.Password)
                .Where(list => list.Id == request.Id)
                .Select(list => new UserDto
                {
                    Id = list.Id,
                    UserName = list.UserName,
                    Email = list.Email,
                    IsAdmin = list.IsAdmin,
                    Password = list.Password,
                })
                .FirstOrDefaultAsync(cancellationToken);

            return response;
        }
    }
}
