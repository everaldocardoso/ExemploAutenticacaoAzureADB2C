using LoginAzureActiveDirectoryB2CWebAPI.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace LoginAzureActiveDirectoryB2CWebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [RequiredScope("read")]
    public class ClientesRestritosController : ControllerBase
    {
        private List<Cliente> Clientes { get; }

        private ILogger<ClientesRestritosController> Logger { get; }

        public ClientesRestritosController(ILogger<ClientesRestritosController> logger)
        {
            Logger = logger;

            Clientes = new List<Cliente>()
            {
                new Cliente("Everaldo", "Araújo", DateTime.Parse("26/03/1994"), "14644293750"),
                new Cliente("Suellene", "Moledo", DateTime.Parse("04/10/1989"), "12209580773"),
                new Cliente("Daniel", "Moledo", DateTime.Parse("23/04/2021"), "54484335241")
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                new
                {
                    Registros = Clientes.Count,
                    Dados = Clientes
                });
        }
    }
}
