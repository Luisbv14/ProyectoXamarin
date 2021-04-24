using System;
using System.Collections.Generic;
using System.Text;
using SQLite; 

namespace Proyecto.Model
{
    [Table("Tarjetas")]
    class Tarjetas
    {
        [PrimaryKey, MaxLength(50)]
        public String numTarjeta { get; set; }

        [MaxLength(50), Unique]
        public String ccv { get; set; }

        [MaxLength(50)]
        public String Titular { get; set; }

        [MaxLength(50)]
        public String tipo { get; set; }

        public float monto { get; set; }
    }
}
