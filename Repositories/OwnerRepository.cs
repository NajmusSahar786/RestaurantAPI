using Entities;
using Entities.Models;
using IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(AppDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
