using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    public class Usuario
    {
        public String cedula { get; set; }
        public String username { get; set; }
        public String contraseña { get; set; }
        public String correo { get; set; }
        public String telefono { get; set; }
        public String numTarjeta { get; set; }
        public String tipo { get; set; }
        
        //CONSTRUCTOR DE LA CLASE USUARIO
        public Usuario(String cedula, String username, String contraseña, String correo, String telefono, String numTarjeta, String tipo)
        {
            this.cedula = cedula;
            this.username = username;
            this.contraseña = contraseña;
            this.correo = correo;
            this.telefono = telefono;
            this.numTarjeta = numTarjeta;
            this.tipo = tipo;
        }

        //METODO PARA PRUEBAS
        public Usuario(String username, String contraseña, String correo)
        {
            this.cedula = cedula;
            this.username = username;
            this.contraseña = contraseña;
            this.correo = correo;
        }
    }
}
