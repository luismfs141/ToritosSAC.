using System;
using System.Collections.Generic;

namespace ToritosSAC.Entities
{
    public partial class Provincium
    {
        public Provincium()
        {
            Distritos = new HashSet<Distrito>();
        }

        public string IdProvinciaC { get; set; } = null!;
        public string IdDepartamentoC { get; set; } = null!;
        public string NombreNv { get; set; } = null!;

        public virtual Departamento IdDepartamentoCNavigation { get; set; } = null!;
        public virtual ICollection<Distrito> Distritos { get; set; }
    }
}
