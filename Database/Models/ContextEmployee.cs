using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database.Models
{
    class ContextEmployee: DbContext
    {
        public ContextEmployee() : base("DefaultConnection")
        {

        }
        public DbSet<Employee> Angajatis { get; set; }
    }
}
