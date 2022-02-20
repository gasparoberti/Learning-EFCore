using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public int Dni { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime? FNac { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
