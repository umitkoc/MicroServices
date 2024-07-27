using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Core.Entities;

namespace Restaurant.Infrastructure.Data
{
    public interface IDatabaseContext
    {
        public List<Customer> Customers { get; set; }
    }
}
