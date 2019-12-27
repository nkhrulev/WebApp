using DataAccess.Models;

namespace DataAccess
{
    public interface IGeoRepository
    {
        Location GetLocationsByIP(ulong ip);
        Location GetLocationsByCity(string city);
    }
}
