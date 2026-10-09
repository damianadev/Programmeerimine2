using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Data
{
    public class Car
    {
        public int id { get; set; }

        [Required]
        public bool ReservationNo { get; set; }

        public int CarModelId { get; set; }
        
    }
}
