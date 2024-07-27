using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.Entities;

namespace Restaurant.Core.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomer(string id);
    }
}
