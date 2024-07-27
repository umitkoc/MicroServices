using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Restaurant.Application.Responses;

namespace Restaurant.Application.Queries
{
    public class GetCustomerQuery:IRequest<CustomerResponse>
    {
        public string? Id { get; set; }
    }
}
