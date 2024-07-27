using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Application.Mappers;
using Contact.Application.Queries;
using Contact.Application.Responses;
using Contact.Core.Repositories;
using MediatR;

namespace Contact.Application.Handlers
{
    public class GetProductHandler:IRequestHandler<GetProductQuery,ProductResponse>
    {
        private readonly IProductRepository _productRepository;
        public GetProductHandler(IProductRepository productRepository)
        {
            _productRepository= productRepository;
        }
        public async Task<ProductResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product =await _productRepository.GetProduct(request.Id!);
            var productResponse = Mapper.ProductMapper.Map<ProductResponse>(product);

            return  await Task.FromResult(productResponse);
        }
    }
}
