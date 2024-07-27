using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Application.Responses;
using MediatR;

namespace Contact.Application.Queries
{
    public class GetProductQuery:IRequest<ProductResponse>
    {
        public string? Id { get; set; }

      
    }
}
