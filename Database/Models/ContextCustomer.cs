using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database.Models
{
    class ContextCustomer: DbContext
    {
        public ContextCustomer() : base("DefaultConnection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
