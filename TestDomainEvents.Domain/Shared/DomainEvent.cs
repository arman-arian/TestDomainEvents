namespace TestDomainEvents.Domain.Shared
{
    public static class DomainEvent
    {
        public static IEventDispatcher Dispatcher { get; set; }

        public static void Raise<T>(object sender, T @event) where T : IDomainEvent
        {
            Dispatcher.Dispatch(sender, @event);
        }

        //public static void Raise<T>(T @event) where T : IDomainEvent
        //{
        //    Dispatcher.Dispatch(@event);
        //}
    }
}
