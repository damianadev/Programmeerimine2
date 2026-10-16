using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class ListCarManufacturerQuery : IRequest<IEnumerable<CarManufacturer>>
    {
    }
}
