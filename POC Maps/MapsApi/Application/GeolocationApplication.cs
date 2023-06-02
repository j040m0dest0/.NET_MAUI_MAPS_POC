using MapsApi.DTO;
using MapsApi.Interface;
using MapsApi.Models;

namespace MapsApi.Application
{
    public class GeolocationApplication : IGeoLocationInterfaces
    {
        private readonly PocNetMauiContext _context;

        public GeolocationApplication(PocNetMauiContext context)
        {
            _context = context;
        }

        public async Task<Historico> AddHistorico(GeoLocationDto geoLocation)
        {

            var geoDto = new Historico()
            {
                Lat= geoLocation.Lat,
                Long= geoLocation.Long,
            };


            _context.Historicos.AddAsync(geoDto);


            await _context.SaveChangesAsync();

            return geoDto;
        }
    }
}
