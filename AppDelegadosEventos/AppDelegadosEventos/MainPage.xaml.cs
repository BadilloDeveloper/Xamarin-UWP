using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace AppDelegadosEventos
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            rectColor1.Tapped += rectColor1_Tapped;

            ColorChanger.ChangeColor += CambiaColorElipses;
            ColorChanger.ChangeColor += CambiacolorRectangulos;
        
        }

        

        public void CambiaColorElipses(Color c)
        {
           foreach(Object o in mycanvas.Children)
            {
                if (o is Ellipse)
                {
                    Ellipse e = o as Ellipse;
                    e.Fill = new SolidColorBrush(c);

                }


            }
        }

        public void CambiacolorRectangulos(Color c)
        {
            foreach (Object o in mycanvas.Children)
            {
                if (o is Rectangle)
                {
                    Rectangle e = o as Rectangle;
                    e.Fill = new SolidColorBrush(c);

                }


            }

        }


        private void rectColor1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Rectangle r = sender as Rectangle;
            if(r!=null){
                SolidColorBrush color = r.Fill as SolidColorBrush;
                ColorChanger.OnchangeColor(color.Color);
            }



        }

        private void rectColor4_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Rectangle r = sender as Rectangle;
            if (r != null)
            {
                SolidColorBrush color = r.Fill as SolidColorBrush;
                ColorChanger.OnchangeColor(color.Color);
            }


        }

        private void mycanvas_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 100;
            rect.Height = 50;
            rect.Margin = new Thickness(e.GetPosition(mycanvas).X, e.GetPosition(mycanvas).Y, 0, 0);
            rect.Fill = new SolidColorBrush(Colors.AliceBlue);
            mycanvas.Children.Add(rect);
        }
    }
}
