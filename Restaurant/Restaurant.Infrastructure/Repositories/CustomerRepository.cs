using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.Entities;
using Restaurant.Core.Repositories;
using Restaurant.Infrastructure.Data;

namespace Restaurant.Infrastructure.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly IDatabaseContext _context;
        public CustomerRepository(IDatabaseContext context)
        {
            _context=context;
        }

        public  Task<Customer> GetCustomer(string id)
        {
            var model =  _context.Customers.Find(i => true);
            return Task.FromResult(model!);
        }
    }
}
