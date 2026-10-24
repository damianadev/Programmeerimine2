using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class InvoiceLineDto
    {
        public int id { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public int ReservationId { get; set; }
    }
}
