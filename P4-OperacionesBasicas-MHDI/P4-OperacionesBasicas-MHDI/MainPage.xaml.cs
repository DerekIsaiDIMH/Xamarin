using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P4_OperacionesBasicas_MHDI
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
            int suma = n1 + n2;
            //Se mostrara el resultado por una ventana emergente
            DisplayAlert("El resultado de la SUMA es: ", suma.ToString(), "Cancelar");
        }
        private void Restar_Clicked(object sender, EventArgs e)
        {
            //Para pocesar los datos registrados
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int resta = n1 - n2;
            //Se mostrara el resultado por una ventana emergente
            DisplayAlert("El resultado de la RESTA es: ", resta.ToString(), "Cancelar");
        }
        private void Multiplicar_Clicked(object sender, EventArgs e)
        {
            //Para pocesar los datos registrados
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int multiplica = n1 * n2;
            //Se mostrara el resultado por una ventana emergente
            DisplayAlert("El resultado de la MULTIPLICACIÓN es: ", multiplica.ToString(), "Cancelar");
        }
        private void Dividir_Clicked(object sender, EventArgs e)
        {
            //Para pocesar los datos registrados
            int n1 = Convert.ToInt32(num1.Text);
            int n2 = Convert.ToInt32(num2.Text);
            int divide = n1 / n2;
            //Se mostrara el resultado por una ventana emergente
            DisplayAlert("El resultado de la DIVISIÓN es: ", divide.ToString(), "Cancelar");
        }
    }
}
