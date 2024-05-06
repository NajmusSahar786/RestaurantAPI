using Entities.Models;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                     new Employee
                     {
                         EmpID = 1,
                         Name = "Mary",
                         Department = Dept.IT,
                         Email = "mary@pragimtech.com"
                     },
            new Employee
            {
                EmpID = 2,
                Name = "John",
                Department = Dept.HR,
                Email = "john@pragimtech.com"
            }
                );
        }
    }
}
