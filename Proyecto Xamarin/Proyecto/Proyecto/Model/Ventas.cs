using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Proyecto.Model
{
    [Table("Ventas")]
    class Ventas
    {
        [PrimaryKey]
        public int codigoVentas { get; set; }

        public float monto { get; set; }

        [MaxLength(50)]
        public String correo { get; set; }

        [MaxLength(50)]
        public String marca { get; set; }
        
        [MaxLength(50)]
        public String modelo { get; set; }

        [MaxLength(50)]
        public String color { get; set; }
    }
}
