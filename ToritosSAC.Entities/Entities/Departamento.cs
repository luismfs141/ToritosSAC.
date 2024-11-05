using System;
using System.Collections.Generic;

namespace ToritosSAC.Entities
{
    public partial class Departamento
    {
        public Departamento()
        {
            Provincia = new HashSet<Provincium>();
        }

        public string IdDepartamentoC { get; set; } = null!;
        public string NombreNv { get; set; } = null!;

        public virtual ICollection<Provincium> Provincia { get; set; }
    }
}
