using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto.Model
{ 
    [Table("Usuario")]  
class Usuario
{
    [PrimaryKey, MaxLength(50)]
    public String correo { get; set; }

    [MaxLength(50), NotNull, Unique]
    public String username { get; set; }

    [MaxLength(50), NotNull]
    public String contraseña { get; set; }




    }

}