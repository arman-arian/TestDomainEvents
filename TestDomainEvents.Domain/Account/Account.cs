using System.Collections.Generic;
using TestDomainEvents.Domain.Events;
using TestDomainEvents.Domain.Shared;

namespace TestDomainEvents.Domain.Account
{
    public class Account
    {
        public Account()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }

        public decimal Balance { get; set; }

        public string Description2 { get; set; }

        public long CreatedOn { get; set; }

        public long ModifiedOn { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public void AddCustomer(Customer customer)
        {
            DomainEvent.Raise(this, new EndOfSurveyEvent() {Customer = new Customer() {FullName = "Arman"} });
        }
    }

}
