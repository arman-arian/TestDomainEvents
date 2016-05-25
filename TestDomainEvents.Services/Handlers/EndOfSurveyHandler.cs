using System;
using TestDomainEvents.Domain.Events;
using TestDomainEvents.Domain.Shared;

namespace TestDomainEvents.Services.Handlers
{
    public class EndOfSurveyHandler : IDomainHandler<EndOfSurveyEvent>
    {
        public void Handle(object sender, EndOfSurveyEvent args)
        {
            Console.WriteLine(args.Customer.FullName);
        }
    }
}
