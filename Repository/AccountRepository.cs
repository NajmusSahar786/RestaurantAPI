using Entities;
using Entities.Models;
using IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(AppDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
