using BookifyDomain.Abstractions;

namespace BookifyDomain.Bookings.Events;

public record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;