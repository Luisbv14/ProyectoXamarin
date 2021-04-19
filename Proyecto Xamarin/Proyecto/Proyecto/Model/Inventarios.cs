using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto.Model
{
    [Table("Inventarios")]
    class Inventarios
    {

        [PrimaryKey, NotNull, MaxLength(50)]
        public String codigoStock { get; set; }

        [NotNull, Unique, MaxLength(50)]
        public String codigoProducto { get; set; }

        [NotNull]
        public int cantidad { get; set; }
    }
}