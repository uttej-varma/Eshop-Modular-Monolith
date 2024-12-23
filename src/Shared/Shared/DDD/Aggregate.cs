﻿namespace Shared.DDD
{
    public abstract class Aggregate<TId>: Entity<TId>, IAggregate<TId>
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public IDomainEvent[] ClearDomainEvents() { 
          IDomainEvent[] dequedEvents = _domainEvents.ToArray();
          _domainEvents.Clear();
          return dequedEvents;
        }
    }
}