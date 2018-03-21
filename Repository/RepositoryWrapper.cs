using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        public IOwnerRepository Owner { get; set; }
        public IAccountRepository Account { get; set; }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            this.Owner = new OwnerRepository(repositoryContext);
            this.Account = new AccountRepository(repositoryContext);
        }
    }
}
