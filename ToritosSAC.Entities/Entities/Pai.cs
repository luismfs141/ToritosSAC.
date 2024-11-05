﻿using System;
using System.Collections.Generic;

namespace ToritosSAC.Entities
{
    public partial class Pai
    {
        public Pai()
        {
            Proveedors = new HashSet<Proveedor>();
        }

        public string IdPaisI { get; set; } = null!;
        public string NombreNv { get; set; } = null!;

        public virtual ICollection<Proveedor> Proveedors { get; set; }
    }
}
