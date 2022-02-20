using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public int? Legajo { get; set; }
        public DateTime? FAlta { get; set; }
        public int? CuentaSueldo { get; set; }
        public int? FkId { get; set; }

        public virtual Persona? Fk { get; set; }
    }
}
