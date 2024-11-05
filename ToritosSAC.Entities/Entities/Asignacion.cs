using System;
using System.Collections.Generic;

namespace ToritosSAC.Entities
{
    public partial class Asignacion
    {
        public Asignacion()
        {
            DetalleGrupos = new HashSet<DetalleGrupo>();
        }

        public int IdAsignacionI { get; set; }
        public string TipoAsignacionC { get; set; } = null!;
        public DateTime FechaAsignacionD { get; set; }
        public DateTime? FechaEntregaVehiculoD { get; set; }
        public int IdVehiculoI { get; set; }

        public virtual Vehiculo IdVehiculoINavigation { get; set; } = null!;
        public virtual ICollection<DetalleGrupo> DetalleGrupos { get; set; }
    }
}
