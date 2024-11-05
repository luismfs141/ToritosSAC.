using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToritosSAC.Entities;

namespace ToritosSAC.DataAccess
{
    public class DACliente
    {
       public Cliente DACLIE_ObtenerPorId(int x_idCliente)
        {
            try
            {
                ToritosDBContext ctx = new ToritosDBContext();
                Cliente cliente = ctx.Clientes.SingleOrDefault(c=>c.IdClienteI == x_idCliente);

                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
