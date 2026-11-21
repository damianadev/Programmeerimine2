using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.Users;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Features.Users
{
    public class ListUserQueryHandler : IRequestHandler<ListUserQuery, OperationResult<PagedResult<UserDto>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public ListUserQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OperationResult<PagedResult<UserDto>>> Handle(ListUserQuery request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<PagedResult<UserDto>>();
            result.Value = await _dbContext.Users
                .AsNoTracking()
                .OrderByDescending(list => list.Id)
                .Select(list => new UserDto
                {
                    Id = list.Id,
                    UserName = list.UserName,
                    Email = list.Email,
                    IsAdmin = list.IsAdmin,
                    Password = list.Password,
                })
                .GetPagedAsync(request.Page, request.PageSize);

            return result;
        }
    }
}
