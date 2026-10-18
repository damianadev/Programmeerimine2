using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.CarModels
{
    public class ListCarModelQuery : IRequest<IEnumerable<CarModel>>
    {
    }
}
