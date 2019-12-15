using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ET5_1_Navegacion_Javier_Badillo
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pagina2));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            if (e.Parameter is string && (string)(e.Parameter) == "3")
            {
                Frame.BackStack.Remove(this.Frame.BackStack.LastOrDefault());
                Frame.BackStack.Remove(this.Frame.BackStack.LastOrDefault());
                Frame.BackStack.Remove(this.Frame.BackStack.LastOrDefault());
            }

            Frame frame = Window.Current.Content as Frame;


            if (frame != null)
            {
                if (frame.CanGoBack)
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
                }
                else { SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed; }


                string piladellamadas = "";
                foreach(PageStackEntry page in frame.BackStack)
                {
                    piladellamadas += page.SourcePageType.Name.ToString()+ "\n" ;
                }
                txtpila.Text = piladellamadas;
            }

        }

        private async void button_Click2(object sender, RoutedEventArgs e)
        {
            CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;

            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(Pagina2),null);
                Window.Current.Content = frame;
                Window.Current.Activate();
                newViewId = ApplicationView.GetForCurrentView().Id;
            });

            bool viewShow = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);



        }


    }
}
