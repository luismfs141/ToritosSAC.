using Microsoft.AspNetCore.Mvc;
using ToritosSAC.DataAccess;
using ToritosSAC.Entities;

namespace ToritosSAC.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet("ObtenerClientePorId/{x_idCliente}")]
        public Cliente ObtenerClientePorId(int x_idCliente)
        {
            DACliente dACliente = new DACliente();
            return dACliente.DACLIE_ObtenerPorId(x_idCliente);
        }
    }
}
