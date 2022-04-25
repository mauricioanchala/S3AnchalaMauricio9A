using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S2AnchalaMauricio9A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void BtnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = TxtUsuario.Text;
            string clave = TxtPass.Text;
            if(usuario=="estudiante2022" && clave == "uisrael2022")
            {
                await Navigation.PushAsync(new MainPage(TxtUsuario.Text, TxtPass.Text));
            }
            else
            {
                DisplayAlert("Error", "Usuario Incorrecto", "Aceptar");
            }
            
            
        }
    }
}