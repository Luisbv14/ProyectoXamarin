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


    }
}
