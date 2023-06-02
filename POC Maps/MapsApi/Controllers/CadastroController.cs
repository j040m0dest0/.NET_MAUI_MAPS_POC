using MapsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MapsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly PocNetMauiContext _appdbContext;
        public CadastroController(PocNetMauiContext appdbContext)
        {
            _appdbContext = appdbContext;
        }

        // GET: api/<CadastroController>
        [HttpGet("GetCadastro")]
        public async Task<ActionResult<List<Cadastro>>> Getcadastro()
        {
            var cadastro = await _appdbContext.Cadastros.ToListAsync();

            return Ok(cadastro);
        }

        [HttpGet("Get-Login")]
        public async Task<ActionResult> GetUserToLogin(string email, string senha)
        {
            var users = _appdbContext.Cadastros.FirstOrDefault(x => x.Email == email && x.Senha == senha);
            if (users == null)
            {
                return BadRequest("Not found");
            }
            
            return Ok("user in DataBase");
        }

        // GET api/<CadastroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CadastroController>
        [HttpPost]
        public async Task<int> AddUser(string nome, string email, string senha)
        {
            //   await _appdbContext.Historicos.AddAsync(hist);

            var user = new Cadastro()
            {
                Nome = nome,
                Email = email,
                Senha = senha
            };

            _appdbContext.Add(user);

            var result = _appdbContext.SaveChanges();

            if (result < 0) return result;

            return result;
        }
        // PUT api/<CadastroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CadastroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
