using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace KooliProjekt.Application.Data
{
    public class CarModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public int CarManufacturerId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TimePrice { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal KmPrice { get; set; }
    }
}
