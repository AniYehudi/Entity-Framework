using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database.Models
{
    class ContextProduct : DbContext
    {
        public ContextProduct() : base("DefaultConnection")
        {

        }
        public DbSet<Fisch> Products { get; set; }
    }
}
