using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto.Model
{
    [Table("Abonos")]
    class Abonos
    {

        [PrimaryKey, MaxLength(50), NotNull]
        public String codigoAbono { get; set; }

        [MaxLength(50), Unique, NotNull]
        public String codigoVentasEsp { get; set; }

        [NotNull]
        public float monto { get; set; }

        [NotNull]
        public DateTime fecha { get; set; }
    }
}