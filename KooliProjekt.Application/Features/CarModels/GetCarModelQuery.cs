using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Dto;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.CarModels
{
    public class GetCarModelQuery : IRequest<OperationResult<CarModelDto>>
    {
        public int Id { get; set; }
    }
}
