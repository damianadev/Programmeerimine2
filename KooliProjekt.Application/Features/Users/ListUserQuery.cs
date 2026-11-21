using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Paging;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;
using Microsoft.Identity.Client;

namespace KooliProjekt.Application.Features.Users
{
    public class ListUserQuery : IRequest<OperationResult<PagedResult<UserDto>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
