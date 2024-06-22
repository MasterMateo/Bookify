using BookifyDomain.Abstractions;

namespace BookifyDomain.Users.Events;

public record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;