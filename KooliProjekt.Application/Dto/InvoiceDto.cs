using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class InvoiceDto
    {
        public int id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueTime { get; set; }
        public bool Paid { get; set; }
        public int CustomerId { get; set; }
    }
}
