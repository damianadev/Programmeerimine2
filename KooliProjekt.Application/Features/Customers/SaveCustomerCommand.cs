using System;
using System.Collections.Generic;
using System.Text;
using KooliProjekt.Application.Behaviors;
using KooliProjekt.Application.Infrastructure.Results;
using MediatR;

namespace KooliProjekt.Application.Features.Customers
{
    public class SaveCustomerCommand : IRequest<OperationResult>, ITransactional
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public bool LoggedIn { get; set; }

        public string Password { get; set; }
    }
}
