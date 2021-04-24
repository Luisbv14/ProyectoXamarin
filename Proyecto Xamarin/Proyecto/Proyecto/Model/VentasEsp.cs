using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto.Model
{
    [Table("VentasEsp")]
    class VentasEsp
    {
        [PrimaryKey, MaxLength(50)]
        public String codigoVentasEsp { get; set; }

        [NotNull]
        public int CodigoVentas { get; set; }

        [MaxLength(100), NotNull]
        public String descripcion { get; set; }

        [MaxLength(50), NotNull]
        public String codigoProducto { get; set; }
    }
}
