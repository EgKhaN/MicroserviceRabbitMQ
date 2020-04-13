using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository _accountRepository)
        {
            accountRepository = _accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }
    }
}
