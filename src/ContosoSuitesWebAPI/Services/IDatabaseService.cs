using global::ContosoSuitesWebAPI.Entities;

namespace ContosoSuitesWebAPI.Services;

public interface IDatabaseService
{
    Task<IEnumerable<Booking>> GetBookingsMissingHotelRooms();
    Task<IEnumerable<Booking>> GetBookingsWithMultipleHotelRooms();

}