using MapsApi.DTO;
using MapsApi.Models;

namespace MapsApi.Interface
{
    public interface IGeoLocationInterface
    {
        Task<Historico> AddHistorico(GeoLocationDto geoLocation);
    }
}
