using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDomainEvents.Domain.Account;
using TestDomainEvents.Domain.Shared;
using TestDomainEvents.Services.Shared;

namespace TestDomainEvents.Services.Services
{
    public class AccountService : GlobalService
    {
        public void Transfer()
        {
            Account account = new Account();
            account.AddCustomer(new Customer() { FullName = "xxX" });
        }
    }

    public class GlobalService
    {
        protected GlobalService()
        {
            DomainEvent.Dispatcher = new ActionDomainEventDispatcher();
        }
    }

}
