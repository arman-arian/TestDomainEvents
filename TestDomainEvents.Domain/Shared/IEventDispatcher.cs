namespace TestDomainEvents.Domain.Shared
{
    public interface IEventDispatcher
    {
        void Dispatch<TEvent>(object sender, TEvent eventToDispatch) where TEvent : IDomainEvent;

        //void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent;
    }
}
