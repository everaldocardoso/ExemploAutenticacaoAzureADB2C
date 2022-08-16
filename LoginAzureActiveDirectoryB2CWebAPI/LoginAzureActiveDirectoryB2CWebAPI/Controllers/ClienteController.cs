using LoginAzureActiveDirectoryB2CWebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace LoginAzureActiveDirectoryB2CWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private List<Cliente> Clientes { get; }

        private ILogger<ClienteController> Logger { get; }

        public ClienteController(ILogger<ClienteController> logger)
        {
            Logger = logger;

            Clientes = new List<Cliente>()
            {
                new Cliente("Everaldo", "Araújo", DateTime.Parse("26/03/1994"), "14644293750"),
                new Cliente("Suellene", "Moledo", DateTime.Parse("04/10/1989"), "12209580773"),
                new Cliente("Daniel", "Moledo", DateTime.Parse("23/04/2021"), "54484335241"),
                new Cliente("Marcia", "Maria", DateTime.Parse("05/05/1970"), "15465464646"),
                new Cliente("Eduardo", "Da Silva", DateTime.Parse("15/02/2008"), "1498797979"),
                new Cliente("Edivaldo", "Cardoso", DateTime.Parse("13/04/1960"), "4899879879"),
                new Cliente("Rosangela", "Moledo", DateTime.Parse("29/10/1964"), "9874654665"),
                new Cliente("Suellen", "Moledo", DateTime.Parse("14/01/1988"), "654654646"),
                new Cliente("Jonas", "De Paulo", DateTime.Parse("15/10/1961"), "546546789872")
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