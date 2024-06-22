using BookifyDomain.Abstractions;

namespace BookifyDomain.Bookings.Events;

public record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;