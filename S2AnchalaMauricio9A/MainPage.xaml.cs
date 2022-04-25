using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S2AnchalaMauricio9A
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

        public MainPage(string strUsuario, string strPassword)
        {
            InitializeComponent();
            LblUsuario.Text = "Bienvenido Usuario: "+strUsuario;
            //LblPassword.Text = strPassword;
        }
        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtSeg1.Text)*0.30;
            double examen1 = Convert.ToDouble(txtExa1.Text)*0.20;
            
            double nota2 = Convert.ToDouble(txtSeg2.Text)*0.30;
            double examen2 = Convert.ToDouble(txtExa2.Text)*0.20;
            double total1 = nota1 + examen1;
            double total2 = nota2 + examen2;
            double total = total1 + total2;
            lblParcial1.Text = "Nota Parcial 1 = " + total1;
            lblParcial2.Text = "Nota Parcial 2 = " + total2;

            if (total >= 7)
            {
                lblFinal.Text = "Nota Final = " + total+ " Aprobado";
            }
            else if (total >= 5 && total<=6.9)
                {
                lblFinal.Text = "Nota Final = " + total + " Complementario";
                }
            else if (total < 5)
            {
                lblFinal.Text = "Nota Final = " + total + " REPROBADO";
            }

            DisplayAlert("Mensaje de Bienvenida", lblFinal.Text, "Gracias");
        }

       

        private void txtSeg1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota1 = Convert.ToDouble(txtSeg1.Text);
            if (nota1 > 10 || nota1 < 0)
            {
                DisplayAlert("Mensaje Error", "Error nota incorrecta", "Aceptar"); 
            }
            
        }

        private void txtExa1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double examen1 = Convert.ToDouble(txtExa1.Text);
            if (examen1 > 10 || examen1 < 0)
            {
                DisplayAlert("Mensaje Error", "Error nota incorrecta", "Aceptar");
            }
        }

        private void txtSeg2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota1 = Convert.ToDouble(txtSeg2.Text);
            if (nota1 > 10 || nota1 < 0)
            {
                DisplayAlert("Mensaje Error", "Error nota incorrecta", "Aceptar");
            }
        }

        private void txtExa2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota1 = Convert.ToDouble(txtExa2.Text);
            if (nota1 > 10 || nota1 < 0)
            {
                DisplayAlert("Mensaje Error", "Error nota incorrecta", "Aceptar");
            }
        }

       
    }
}
