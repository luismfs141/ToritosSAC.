using System;
using System.Collections.Generic;

namespace ToritosSAC.Entities
{
    public partial class DetalleGrupo
    {
        public DetalleGrupo()
        {
            DetalleEstadoCuenta = new HashSet<DetalleEstadoCuentum>();
        }

        public int IdDetalleGrupoI { get; set; }
        public int IdGrupoI { get; set; }
        public int IdClienteI { get; set; }
        public int? IdDocumentosI { get; set; }
        public int? IdAsignacionI { get; set; }
        public bool ClienteAdminBo { get; set; }

        public virtual Asignacion? IdAsignacionINavigation { get; set; }
        public virtual Cliente IdClienteINavigation { get; set; } = null!;
        public virtual Documento? IdDocumentosINavigation { get; set; }
        public virtual Grupo IdGrupoINavigation { get; set; } = null!;
        public virtual ICollection<DetalleEstadoCuentum> DetalleEstadoCuenta { get; set; }
    }
}
