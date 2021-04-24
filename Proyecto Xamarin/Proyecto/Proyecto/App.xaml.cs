using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using Proyecto.Model; 

namespace Proyecto
{
    public partial class App : Application
    {
        public App(string filename)
        {
            InitializeComponent();
            DBConfig.Inicializador(filename);

            //llenarLista(5);
            MainPage = new NavigationPage(new MainPage());

            llenarTarjetas();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        //LISTA DE USUARIOS
       public static List<Usuario> listaUsuarios = new List<Usuario>();

      public void llenarLista(int cantUsuarios) //cantusuarios es por si quisieramos crear usuarios aleatorios en cantidades altas
        {
            listaUsuarios.Add(new Usuario("Luis", "123", "Luis@gmail.com"));
            listaUsuarios.Add(new Usuario("Jean", "123", "Jean@gmail.com"));
            listaUsuarios.Add(new Usuario("Jose", "123", "Jose@gmail.com"));
            listaUsuarios.Add(new Usuario("Nicole", "123", "Nicole@gmail.com"));
            listaUsuarios.Add(new Usuario("Sebastian", "123", "Sebastian@gmail.com"));
        } 

        public void llenarTarjetas()
        {
            DBConfig.Instancia.AgregarTarjeta("5397237858238569", "755", "Nicole Valeria Rodríguez Guerrero", "MasterCard", 100000000);
            DBConfig.Instancia.AgregarTarjeta("4645514457901786", "748", "Luis Enrique Brenes Valverde", "VISA", 100000000);
            DBConfig.Instancia.AgregarTarjeta("5305181663268265", "608", "Jean Franco Amaya Siso", "MasterCard", 100000000);
            DBConfig.Instancia.AgregarTarjeta("340859458221627", "910", "Jose Pablo Fonseca Rojas", "American Express", 100000000);
            DBConfig.Instancia.AgregarTarjeta("4992459335963252", "248", "Sebastián Quiroga Alfaro", "VISA", 100000000);
        }
    }
}
