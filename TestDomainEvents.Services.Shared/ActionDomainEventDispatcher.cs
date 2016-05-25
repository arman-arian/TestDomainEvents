using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using TestDomainEvents.Domain.Shared;

namespace TestDomainEvents.Services.Shared
{
    public class ActionDomainEventDispatcher : IEventDispatcher
    {
        private readonly Assembly _assembly;

        public ActionDomainEventDispatcher()
        {
            _assembly = Assembly.GetCallingAssembly();
        }

        //public void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent
        //{
        //    var types = EventContainer.GetAll<IDomainHandler<TEvent>>(_assembly);
        //    foreach (var instance in types.Select(Activator.CreateInstance))
        //    {
        //        instance.GetType().GetMethod("Handle").Invoke(instance, new object[] { eventToDispatch });
        //    }
        //}

        public void Dispatch<TEvent>(object sender, TEvent eventToDispatch) where TEvent : IDomainEvent
        {
            var types = EventContainer.GetAll<IDomainHandler<TEvent>>(_assembly);
            foreach (var instance in types.Select(Activator.CreateInstance))
            {
                instance.GetType().GetMethod("Handle").Invoke(instance, new object[] { sender, eventToDispatch });
            }
        }
    }
}