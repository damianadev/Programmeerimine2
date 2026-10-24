using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class ReservationDto
    {
        public int id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal StartKm { get; set; }
        public decimal EndKm { get; set; }
        public decimal TimePrice { get; set; }
        public decimal KmPrice { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
    }
}
