using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Proyecto.Model
{
    [Table("Ventas")]
    class Ventas
    {
        [PrimaryKey, AutoIncrement]
        public int codigoVentas { get; set; }

        [NotNull]
        public int monto { get; set; }

        [MaxLength(50), NotNull]
        public String cedula { get; set; }
    }
}
