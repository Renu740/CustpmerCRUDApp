using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerCrudApp.Models;

namespace CustomerCrudApp.Data
{
    public class CustomerCrudAppContext : DbContext
    {
        public CustomerCrudAppContext (DbContextOptions<CustomerCrudAppContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerCrudApp.Models.Customer> Customer { get; set; }
    }
}
