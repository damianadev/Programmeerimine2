using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KooliProjekt.Application.Data
{
    public class Reservation
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime StartTime { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime EndTIme { get; set; }

        [Required]
        [Column(TypeName ="decimal(18, 2)")]
        public decimal StartKm { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal EndKm { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TimePrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KmPrice { get; set; }

        public int CarId { get; set; }

        public int CustomerId { get; set }

    }
}
