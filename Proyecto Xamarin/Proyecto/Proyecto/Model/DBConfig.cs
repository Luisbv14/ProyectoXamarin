using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace Proyecto.Model
{
    class DBConfig
    {
        private SQLiteConnection con;
        private static DBConfig instancia;
        public static DBConfig Instancia
        {
            get
            {
                if (instancia == null)
                    throw new Exception("Debe llamar al inicializador, acción detenida");
                return instancia;
            }
        }
        public static void Inicializador(String filename)
        {
            if (filename == null)
            {
                throw new ArgumentException();
            }
            if (instancia != null)
            {
                instancia.con.Close();
            }
            instancia = new DBConfig(filename);
        }
        private DBConfig(String dbPath)
        {
            con = new SQLiteConnection(dbPath);
            con.CreateTable<Usuario>();
            con.CreateTable<Tarjetas>();
            con.CreateTable<Productos>();
            con.CreateTable<Ventas>();
            con.CreateTable<VentasEsp>();
            con.CreateTable<Inventarios>();
            con.CreateTable<Abonos>();
        }


        // ******************************CREAR USUARIO******************************

        public string EstadoMensajeUsuario;
        public int AddNewUser(string username, string correo, string contraseña)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Usuario
                {
                    username = username,
                    correo = correo,
                    contraseña = contraseña
                });
                EstadoMensajeUsuario = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensajeUsuario = e.Message; }
            return result;
        }
        public IEnumerable<Usuario> GetAllUsers()
        {
            try
            {
                return con.Table<Usuario>();
            }
            catch (Exception e)
            {
                EstadoMensajeUsuario = e.Message;
            }
            return Enumerable.Empty<Usuario>();
        }


        // ******************************AGREGAR TARJETA******************************

        public string EstadoMensajeTarjeta;
        public int AgregarTarjeta(string numTarjeta, string ccv, string Titular, string tipo)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Tarjetas
                {
                    numTarjeta = numTarjeta,
                    ccv = ccv,
                    Titular = Titular,
                    tipo = tipo
                });
                EstadoMensajeTarjeta = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensajeTarjeta = e.Message; }
            return result;
        }
        public IEnumerable<Tarjetas> GetAllTarjetas()
        {
            try
            {
                return con.Table<Tarjetas>();
            }
            catch (Exception e)
            {
                EstadoMensajeTarjeta = e.Message;
            }
            return Enumerable.Empty<Tarjetas>();
        }

        // ******************************AGREGAR PRODUCTO******************************

        public string EstadoMensajeProducto;
        public int AgregarProducto(string codigoProducto, string marca, string modelo, string estilo, string combustible, string transmision, string imagen, string año)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Productos
                {
                    codigoProducto = codigoProducto,
                    marca = marca,
                    modelo = modelo,
                    estilo = estilo,
                    combustible = combustible, 
                    transmision = transmision,
                    imagen = imagen, 
                    año = año
                });
                EstadoMensajeProducto = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensajeProducto = e.Message; }
            return result;
        }
        public IEnumerable<Productos> GetAllProductos()
        {
            try
            {
                return con.Table<Productos>();
            }
            catch (Exception e)
            {
                EstadoMensajeProducto = e.Message;
            }
            return Enumerable.Empty<Productos>();
        }


        // ******************************AGREGAR VENTA******************************

        public string EstadoMensajeVenta;
        public int AgregarVenta(int codigoVentas, int monto, string cedula)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Ventas
                {
                    codigoVentas = codigoVentas,
                    monto = monto,
                    cedula = cedula,

                });
                EstadoMensajeVenta = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensajeVenta = e.Message; }
            return result;
        }
        public IEnumerable<Ventas> GetAllVentas()
        {
            try
            {
                return con.Table<Ventas>();
            }
            catch (Exception e)
            {
                EstadoMensajeVenta = e.Message;
            }
            return Enumerable.Empty<Ventas>();
        }

        // ******************************AGREGAR VENTAS ESPECIFICAS******************************

        public string EstadoMensajeVentaEsp;
        public int AgregarVentaEsp(string codigoVentasEsp, int CodigoVentas, string descripcion, string codigoProducto)
        {
            int result = 0;
            try
            {
                result = con.Insert(new VentasEsp
                {
                    codigoVentasEsp = codigoVentasEsp,
                    CodigoVentas = CodigoVentas,
                    descripcion = descripcion,
                    codigoProducto = codigoProducto

                });
                EstadoMensajeVentaEsp = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensajeVentaEsp = e.Message; }
            return result;
        }
        public IEnumerable<VentasEsp> GetAllVentasEsp()
        {
            try
            {
                return con.Table<VentasEsp>();
            }
            catch (Exception e)
            {
                EstadoMensajeVentaEsp = e.Message;
            }
            return Enumerable.Empty<VentasEsp>();
        }

        // ******************************AGREGAR INVENTARIO******************************


        public string EstadoMensajeInventario;
        public int AgregarInventario(string codigoStock, string codigoProducto, int cantidad)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Inventarios
                {
                    codigoStock = codigoStock,
                    codigoProducto = codigoProducto,
                    cantidad = cantidad

                });
                EstadoMensajeInventario = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensajeInventario = e.Message; }
            return result;
        }
        public IEnumerable<Inventarios> GetAllInventarios()
        {
            try
            {
                return con.Table<Inventarios>();
            }
            catch (Exception e)
            {
                EstadoMensajeInventario = e.Message;
            }
            return Enumerable.Empty<Inventarios>();
        }

        // ******************************AGREGAR ABONO******************************

        public string EstadoMensajeAbono;
        public int AgregarAbono(string codigoAbono, string codigoVentasEsp, float monto, DateTime fecha)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Abonos
                {
                    codigoAbono = codigoAbono,
                    codigoVentasEsp = codigoVentasEsp,
                    monto = monto,
                    fecha = fecha

                });
                EstadoMensajeAbono = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensajeAbono = e.Message; }
            return result;
        }
        public IEnumerable<Abonos> GetAllAbonos()
        {
            try
            {
                return con.Table<Abonos>();
            }
            catch (Exception e)
            {
                EstadoMensajeAbono = e.Message;
            }
            return Enumerable.Empty<Abonos>();
        }
    }
}
