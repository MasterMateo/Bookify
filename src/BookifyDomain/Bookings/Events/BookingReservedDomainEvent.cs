using BookifyDomain.Abstractions;

namespace BookifyDomain.Bookings.Events;

public record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;