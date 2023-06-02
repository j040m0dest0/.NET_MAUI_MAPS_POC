using MapsApi.DTO;
using MapsApi.Models;

namespace MapsApi.Interface
{
    public interface IGeoLocationInterfaces
    {
        Task<Historico> AddHistorico(GeoLocationDto geoLocation);
    }
}
