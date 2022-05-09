using Microsoft.AspNetCore.Mvc;
using ProjetoCep.Negocio;
using ProjetoCep.Domain;

namespace ProjetoCep.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepController : ControllerBase
    {
        [HttpGet("{cep}")]
        public async Task<ActionResult<Endereco>> Get(string cep)
        {
            return await new   IntegracaoAPI().buscacep(cep);  
        }
    }
}