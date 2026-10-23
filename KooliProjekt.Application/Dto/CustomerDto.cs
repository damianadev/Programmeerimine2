using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KooliProjekt.Application.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public bool LoggedIn { get; set; }

        public string Password { get; set; }
    }
}
