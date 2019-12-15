using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ET6_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1),OnTimerTick);



        }

        private bool OnTimerTick()
        {
            DateTime now = DateTime.Now;

            lblTiempo.Text = now.ToString("T");
            fecha.Text = now.ToString("D");
            return true;
        }
    }
}
