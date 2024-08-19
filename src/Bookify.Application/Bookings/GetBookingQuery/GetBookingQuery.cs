using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.GetBookingQuery;

public sealed record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;
