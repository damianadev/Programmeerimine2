using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace KooliProjekt.Application.Data
{
    public class Invoice
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime InvoiceDate { get; set; }

        [Required]
        [Column(TypeName ="datetime2")]
        public DateTime DueTime { get; set; }

        [Required]
        public bool Paid { get; set; }

        public int CustomerId { get; set; }

    }
}
