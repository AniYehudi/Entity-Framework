using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database.Models
{
    class ContextInventary : DbContext
    {
        public ContextInventary() : base("DefaultConnection")
        {

        }
        public DbSet<Inventary> Inventarys { get; set; }
    }
}
