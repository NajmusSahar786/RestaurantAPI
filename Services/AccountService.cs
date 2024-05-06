using IRepositories;
using IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AccountService: IAccountService
    {
        private IAccountRepository _accountRepository; 
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
    }
}
