using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class CarDto
    {
        public int id { get; set; }
        public bool ReservationNo { get; set; }
        public int CarModelId { get; set; }
    }
}
