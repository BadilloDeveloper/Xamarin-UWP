using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace CalculadoraXamarin
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        enum Operaciones {desconocida, suma, resta,multiplicacion,division};
        Operaciones op = Operaciones.desconocida;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            double op1, op2, resultado;


            try
            {
                op1 = double.Parse(sum1.Text);
                op2 = double.Parse(sum2.Text);

                op = SeleccionarAccion(sender);
                

               
                if (op != Operaciones.desconocida)
                {
                    resultado = ejecutaCalculo(op1, op2, op);
                    Result.Text = resultado.ToString();

                }



            }
            catch(Exception ex)
            {
                var dialog = new MessageDialog("errorr en la conversión" + ex.ToString()) ;
                await dialog.ShowAsync();
            }


        


        }

        private Operaciones SeleccionarAccion(object sender)
        {
            Button button = (Button)sender;
            string buttonId = button.Name;

            switch (buttonId)
            {
                case "Btnsuma":
                    op = Operaciones.suma;
                    break;
                case "Btnresta":
                    op = Operaciones.resta;
                    break;
                case "BtnMult":
                    op = Operaciones.multiplicacion;
                    break;
                case "BtnDiv":
                    op = Operaciones.division;
                    break;
                default:

                    break;
            }
            return op;
        }

        private double ejecutaCalculo(double op1, double op2, Operaciones op)
        {
            double r = 0;

            switch (op)
            {
                case Operaciones.suma:
                    r = op1 + op2;
                    break;
                case Operaciones.resta:
                    r = op1 - op2;
                    break;
                case Operaciones.multiplicacion:
                    r = op1 * op2;
                    break;
                case Operaciones.division:
                    if (op2 != 0)
                    {
                        r = op1 / op2;
                    }
                    else
                    {
                        r = 0;
                    }
                    break;
                default: r = 0;
                    break;

            }
            return r;

        }
    }
}
