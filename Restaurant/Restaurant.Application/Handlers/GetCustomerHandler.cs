using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Restaurant.Application.Mappers;
using Restaurant.Application.Queries;
using Restaurant.Application.Responses;
using Restaurant.Core.Repositories;

namespace Restaurant.Application.Handlers
{
    public class GetCustomerHandler:IRequestHandler<GetCustomerQuery,CustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<CustomerResponse> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetCustomer(request.Id!);
            var customerResponse = Mapper.CustomerMapper.Map<CustomerResponse>(customer);
            return await Task.FromResult(customerResponse);
        }
    }
}
