using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Proyecto.Model
{
    [Table("Productos")]
    class Productos
    {
        [PrimaryKey, MaxLength(50)]
        public String codigoProducto { get; set; }

        [MaxLength(50), NotNull]
        public String marca { get; set; }

        [MaxLength(50), NotNull]
        public String modelo { get; set; }

        [MaxLength(50), NotNull]
        public String estilo { get; set; }

        [MaxLength(50), NotNull]
        public String combustible { get; set; }

        [MaxLength(50), NotNull]
        public String transmision { get; set; }

        [MaxLength(50), NotNull]
        public String imagen { get; set; }

        [MaxLength(50), NotNull]
        public String año { get; set; }

        [NotNull]
        public int precio{ get; set; }
    }
}
