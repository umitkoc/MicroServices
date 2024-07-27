using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Core.Entities;
using Contact.Core.Repositories;
using Contact.Infrastructure.Data;

namespace Contact.Infrastructure.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly IDatabaseContext _databaseContext;
        public ProductRepository(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public Task<Product?> GetProduct(string productId)
        {
            var model= _databaseContext.Products?.Find(i => true);

            return Task.FromResult(model);
        }
    }
}
