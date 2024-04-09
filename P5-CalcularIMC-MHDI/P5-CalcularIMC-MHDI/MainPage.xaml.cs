using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P5_CalcularIMC_MHDI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            var altura = double.Parse(Altura.Text);
            var peso = double.Parse(Peso.Text);
            var imc = peso/ (altura*altura);
            IMC.Text = imc.ToString();

            string resultado = "";

            if(imc < 18.5)
            {
                resultado = "tienes bajo el peso";
            }
            else
            {
                if(imc >29.9)
                {
                    resultado = "Tienes obesidad";
                }
                else
                {
                    if(imc >=18.5 && imc <= 24.9)
                    {
                        resultado = "Tu peso es normal";
                    }
                    else
                    {
                        resultado = "Tienes sobre peso";
                    }
                }
            }
            DisplayAlert("Resultado", resultado, "ok");
        }
    }
}
