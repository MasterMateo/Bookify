using Bookify.Domain.Apartments;

namespace Bookify.Infrastructure.Repository;

internal class ApartmentRepository : Repository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}
