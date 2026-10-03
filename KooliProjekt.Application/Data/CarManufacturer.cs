using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace KooliProjekt.Application.Data
{
    public class CarManufacturer
    {
        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

    }
}
