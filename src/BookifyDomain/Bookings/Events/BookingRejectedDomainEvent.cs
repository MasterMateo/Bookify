using BookifyDomain.Abstractions;

namespace BookifyDomain.Bookings.Events;

public record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;