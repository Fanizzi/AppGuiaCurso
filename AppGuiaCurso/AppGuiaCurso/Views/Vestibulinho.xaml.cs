using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaCurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vestibulinho : ContentPage
    {
        public Vestibulinho()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Launcher.CanOpenAsync(new Uri("http://www.vestibulinhoetec.com.br"));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}