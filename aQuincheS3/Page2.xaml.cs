using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aQuincheS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string datoUno, int datoDos)
        {
            InitializeComponent();
            lblDatoUno.Text = "DATO UNO:" + datoUno;
            lblDatoDos.Text = "DATO DOS:" + datoDos;

        }

        private void btnAbrirP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}