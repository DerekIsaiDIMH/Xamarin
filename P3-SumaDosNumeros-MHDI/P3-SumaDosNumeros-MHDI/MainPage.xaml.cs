using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P3_SumaDosNumeros_MHDI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        {
            //Para pocesar los datos registrados
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int suma  = n1 + n2;
            //Se mostrara el resultado por una ventana emergente
            DisplayAlert("Mensaje", suma.ToString(), "Cancelar");
        }
    }
}
