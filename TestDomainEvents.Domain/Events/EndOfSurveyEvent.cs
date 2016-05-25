using TestDomainEvents.Domain.Account;
using TestDomainEvents.Domain.Shared;

namespace TestDomainEvents.Domain.Events
{
    public class EndOfSurveyEvent : IDomainEvent
    {
        public Customer Customer { get; set; }
    }
}
