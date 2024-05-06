using Entities;
using IRepositories;
using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
