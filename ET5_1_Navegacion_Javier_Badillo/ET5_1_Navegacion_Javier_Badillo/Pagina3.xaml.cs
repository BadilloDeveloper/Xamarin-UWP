using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ET5_1_Navegacion_Javier_Badillo
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Pagina3 : Page
    {
        public Pagina3()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), "3");
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

         

            if (e.Parameter is string)
            {
                texto.Text = "Recibido " + e.Parameter.ToString() ;
            }
            else
            {
                texto.Text = "Hola mundo!";
            }


            Frame frameroot = Window.Current.Content as Frame;

            string mypages = "";


            foreach (PageStackEntry page in frameroot.BackStack)
            {
                mypages += page.SourcePageType.Name.ToString() + "\n";
            }
            pila.Text = mypages;

            if (frameroot.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }




        }
    }













}


