using MapsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MapsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricoController : ControllerBase
    {
        private readonly PocNetMauiContext _appdbContext;

        public HistoricoController(PocNetMauiContext appdbContext)
        {
            _appdbContext = appdbContext;
        }


        [HttpGet("GetHistorico")]
        public async Task<ActionResult<List<Historico>>> GetHistorico()
        {
            var historico = await _appdbContext.Historicos.ToListAsync();

            return Ok(historico);
        }

        [HttpPost("AddHistorico")]
        public async Task<int> AddHistorico(Historico hist)
        {
          //   await _appdbContext.Historicos.AddAsync(hist);

            var result = _appdbContext.SaveChanges();

            if (result < 0) return result;
            

            return result;
        }

        [HttpPut("UpdateHistorico")]
        public async Task<ActionResult<List<Historico>>> UpdateHistorico()
        {
            var historico = await _appdbContext.Historicos.ToListAsync();

            return Ok(historico);
        }

        [HttpDelete("DeleteHistorico")]
        public async Task<ActionResult<List<Historico>>> DeleteHistorico()
        {
            var historico = await _appdbContext.Historicos.ToListAsync();

            return Ok(historico);
        }
    }
}
