using BusinessLogic.Models;

namespace WebApp.Extensions
{
    internal static class LocationExtensions
    {
        public static Location ToApiModel(this Location location)
        {
            if (location == null)
            {
                return null;
            }

            return new Location(location.Country,
                                location.Region,
                                location.Postal,
                                location.City,
                                location.Organization,
                                location.Latitude,
                                location.Longitude);
        }
    }
}
