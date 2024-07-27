using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.Entities;

namespace Restaurant.Infrastructure.Data
{
    public class DatabaseContext:IDatabaseContext
    {
        public List<Customer> Customers { get; set; }

        public DatabaseContext()
        {
            Customers=new List<Customer>()
            {
                new Customer()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "John Customer Restaurant",
                    Role = "Admin"
                }
            };
        }
    }
}
