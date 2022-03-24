using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            double peso = double.Parse(txt_peso.Text);
            double altura = double.Parse(txt_altura.Text);

            double imc = peso / (altura * altura);
            imc = Math.Round(imc, 2);

            if (imc < 18.5)
            {
                DisplayAlert("Seu IMC", $"Classificação: Abaixo do peso  IMC: {imc}", "Fechar");
            }

            else if (imc >= 18.5 && imc <= 24.9)
            {
                DisplayAlert("Seu IMC", $"Classificação: Peso normal \n" +
                    $"IMC: {imc}", "Fechar");
            }

            else if (imc >= 25 && imc <= 29.9)
            {
                DisplayAlert("Seu IMC", $"Classificação: Sobrepeso \n" +
                    $"IMC: {imc}", "Fechar");
            }

            else if (imc >= 30 && imc <= 34.9)
            {
                DisplayAlert("Seu IMC", $"Classificação: Obesidade grau I \n" +
                    $"IMC: {imc}", "Fechar");
            }

            else if (imc >= 35 && imc <= 39.9)
            {
                DisplayAlert("Seu IMC", $"Classificação: Obesidade grau II \n" +
                    $"IMC: {imc}", "Fechar");
            }

            else
            {
                DisplayAlert("Seu IMC", $"Classificação: Obesidade grau III \n" +
                    $"IMC: {imc}", "Fechar");
            }
        }
    }
}

