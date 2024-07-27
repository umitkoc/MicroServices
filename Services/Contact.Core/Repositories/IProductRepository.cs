using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Core.Entities;

namespace Contact.Core.Repositories
{
    public interface IProductRepository
    { 
        Task<Product?> GetProduct (string productId);
    }
}
