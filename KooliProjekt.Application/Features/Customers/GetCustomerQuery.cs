using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Data;
using MediatR;


namespace KooliProjekt.Application.Features.Customers
{
    public class GetCustomerQuery : IRequest<Customer>
    {
        public int Id { get; set; }
    }
}
