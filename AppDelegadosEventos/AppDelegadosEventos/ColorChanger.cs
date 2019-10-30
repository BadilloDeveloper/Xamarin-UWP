using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace AppDelegadosEventos
{
    public class ColorChanger
    {
        

        public delegate void changeColorDelegate(Color c);
        public static event changeColorDelegate ChangeColor;



        static public void OnchangeColor(Color c)
        {

            if (ChangeColor != null)
            {
                ChangeColor(c);
            }
        }





    }
}
