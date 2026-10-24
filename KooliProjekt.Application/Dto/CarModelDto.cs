using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class CarModelDto
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int CarManufacturerId { get; set; }
        public decimal TimePrice { get; set; }

        public decimal KmPrice { get; set; }
    }
}
