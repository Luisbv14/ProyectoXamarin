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

        [MaxLength(50), NotNull, Unique]
        public String ccv { get; set; }

        [MaxLength(50), NotNull]
        public String Titular { get; set; }

        [MaxLength(50), NotNull]
        public String tipo { get; set; }
/*
        [NotNull]
        public float monto { get; set; }
*/
    }
}
