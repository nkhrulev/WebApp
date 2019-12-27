using BusinessLogic.Models;

namespace BusinessLogic
{
    public interface IGeoSearcher
    {
        Location GetLocationByIP(ulong ip);
        Location GetLocationsByCity(string city);
    }
}
