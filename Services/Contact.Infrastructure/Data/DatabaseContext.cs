using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Core.Entities;

namespace Contact.Infrastructure.Data
{
    public class DatabaseContext : IDatabaseContext
    {
        public DatabaseContext()
        {
            Products = new List<Product>()
            {
                new ()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "John",
                    Username = "Wick"
                }
            };
        }

        public List<Product>? Products { get; set; }
    }
}
