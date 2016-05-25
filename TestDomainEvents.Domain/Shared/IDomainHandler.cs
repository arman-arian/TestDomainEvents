namespace TestDomainEvents.Domain.Shared
{
    public interface IDomainHandler<in T> where T : IDomainEvent
    {
        //void Handle(T @event);

        void Handle(object sender, T @event);
    }
}
