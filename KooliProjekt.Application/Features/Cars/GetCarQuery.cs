using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;

namespace KooliProjekt.Application.Features.Cars
{
    public class GetCarQuery : IRequest<Car>
    {
        public int Id { get; set; }
    }
}
