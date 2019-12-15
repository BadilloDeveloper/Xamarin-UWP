using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ET5_2_Digitos
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

        private void btnclick(object sender, RoutedEventArgs e)
        {
            Button click = sender as Button;


            switch (click.Name)
            {
                case "uno":
                    Resultado.Text += 1;
                    break;
                case "dos":
                    Resultado.Text += 2;
                    break;
                case "tres":
                    Resultado.Text += 3;
                    break;
                case "cuatro":
                    Resultado.Text += 4;
                    break;
                case "cinco":
                    Resultado.Text += 5;
                    break;
                case "seis":
                    Resultado.Text += 6;
                    break;
                case "siete":
                    Resultado.Text += 7;
                    break;
                case "ocho":
                    Resultado.Text += 8;
                    break;
                case "nueve":
                    Resultado.Text += 9;
                    break;
                case "cero":
                    Resultado.Text += 0;
                    break;
                case "coma":
                    Resultado.Text += ',';
                    break;
                case "borra":
                    Resultado.Text = Resultado.Text.Substring(0,Resultado.Text.Length-1);
                    break;
                case "mult":
                    Resultado.Text += '*';
                    break;
                case "sum":
                    Resultado.Text += '+';
                    break;
                case "rest":
                    Resultado.Text += '+';
                    break;

                case "igual":
                    //Resultado.Text ="";
                    try { 
                    string[] sumandos = Resultado.Text.Split('+');
                    string[] restando = Resultado.Text.Split('-');
                    string[] multiplicando = Resultado.Text.Split('*');

                        //suma
                        if (sumandos.Length > 1)
                        {
                            Resultado.Text = (decimal.Parse(sumandos[0]) + decimal.Parse(sumandos[1])).ToString() ;

                        }
                        //resta
                        if (restando.Length > 1)
                        {
                            Resultado.Text = (decimal.Parse(restando[0]) + decimal.Parse(restando[1])).ToString();

                        }
                        //mult
                        if (multiplicando.Length > 1)
                        {
                            Resultado.Text = (decimal.Parse(multiplicando[0]) + decimal.Parse(multiplicando[1])).ToString();

                        }



                    }
                    catch
                    {

                        Resultado.Text = "Operación no valida";
                    }





                    break;

            }



            
        }
    }
}
