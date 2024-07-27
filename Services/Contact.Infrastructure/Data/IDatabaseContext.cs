using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Core.Entities;

namespace Contact.Infrastructure.Data
{
    public interface IDatabaseContext
    {
        public List<Product>? Products { get; set; }
    }
}
