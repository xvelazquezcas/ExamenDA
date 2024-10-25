using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamenDA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        {
            double Numero1 = Convert.ToInt32(Num1.Text);
            double Numero2 = Convert.ToInt32(Num2.Text);
            double Resultado = Numero1 + Numero2;
            Resultado.Text = Resultado.ToString;
            

        }

        private void Restar_Clicked(object sender, EventArgs e)
        {
            double Numero1 = Convert.ToInt32(Num1.Text);
            double Numero2 = Convert.ToInt32(Num2.Text);
            double Resultado = Numero2 - Numero2;
            Resultado.Text = Resultado.ToString;
        }

        private void Dividir_Clicked(object sender, EventArgs e)
        {
            double Numero1 = Convert.ToInt32(Num1.Text);
            double Numero2 = Convert.ToInt32(Num2.Text);
            double Resultado = Numero1 / Numero2;
            Resultado.Text = Resultado.ToString;


        }

        private void Multiplicar_Clicked(object sender, EventArgs e)
        {
            double Numero1 = Convert.ToInt32(Num1.Text);
            double Numero2 = Convert.ToInt32(Num1.Text);
            double Resultado = Numero1 * Numero2;
            Resultado.Text = Resultado.ToString;



        }
    }
}
