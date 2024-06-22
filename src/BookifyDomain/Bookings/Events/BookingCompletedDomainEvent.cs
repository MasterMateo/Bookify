using BookifyDomain.Abstractions;

namespace BookifyDomain.Bookings.Events;

public record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;