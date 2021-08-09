using CustomerCrudApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerCrudApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CustomerCrudAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CustomerCrudAppContext>>()))
            {
                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }
                context.Customer.AddRange(
                    new Customer
                    {
                        FirstName = "Renu",
                        LastName = "Yadav",
                        Gender = "Female",
                        DateOfBirth = DateTime.Parse("1997-06-08"),
                        City = "Surat",
                        Comment ="No Comment",
                    },
                    new Customer
                    {
                        FirstName = "Pratik",
                        LastName = "Solanki",
                        Gender = "Male",
                        DateOfBirth = DateTime.Parse("1995-06-08"),
                        City = "Surat",
                        Comment = "No Comment",
                    },
                    new Customer
                    {
                        FirstName = "Trupti",
                        LastName = "Solanki",
                        Gender = "Female",
                        DateOfBirth = DateTime.Parse("1997-06-08"),
                        City = "Surat",
                        Comment = "No Comment",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
