using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ET_6_2OpenWheater
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnConsulta_Clicked(object sender, EventArgs e)
        {

            using (var cliente = new HttpClient())
            {
               // string apikey = "b73171bf7ac8904c46d9067bc99880f9";
                string url = "http://api.openweathermap.org/data/2.5/weather?q=" + Ciudad.Text+ "&appid=b73171bf7ac8904c46d9067bc99880f9&units=metric&lang=es";
                Task<string> taskjsontxt =  cliente.GetStringAsync(url);

                lblResultado.Text = "Consultando...";

                var jsontxt = await taskjsontxt;

                var data = OpenWheatherClass.FromJson(jsontxt);
                lblResultado.Text = "Nombre estacion: " + data.Name +
                    "\nCiudad: "+ Ciudad.Text+
                    "\nPais: " + data.Sys.Country +
                    "\nTemperatura: " + data.Main.Temp+
                    
                    "ºC\nHumedad: "+ data.Main.Humidity+
                    "%\nDescripción: "+ data.Weather[0].Description;
                lbltemperatura.Text = data.Main.Temp + "Grados ";
                //string iconourl = "http://openweathermap.org/img/w/" + data.Weather[0].Icon + ".png";
                //UriImageSource img = new UriImageSource();
                //img.Uri = new Uri(iconourl);
                //Icono.Source = img;
                 Icono.Source = ImageSource.FromResource("ET_6_2OpenWheater.Images.Weather." + data.Weather[0].Icon + ".png");

                BtnHablame_Clicked(sender, e);
            }


        }

        private async void BtnHablame_Clicked(object sender, EventArgs e)
        {

            await TextToSpeech.SpeakAsync("El tiempo en "+Ciudad.Text +"es de "+ lbltemperatura.Text);

        }
    }
}
