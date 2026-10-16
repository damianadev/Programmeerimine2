using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.CarManufacturers
{
    public class GetCarManufacturerQuery : IRequest<CarManufacturer>
    {
        public int Id { get; set; }
    }
}
