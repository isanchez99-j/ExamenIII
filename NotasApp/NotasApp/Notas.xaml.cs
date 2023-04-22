using Android.Media;
using NotasApp.Models;

using System.Diagnostics;
using Xamarin.Forms;

namespace NotasApp
{
    public partial class Notas : ContentPage
    {
        public MediaPlayer player;
        public Notas()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var Historial = await App.Supa.From<Nota>().Get();
            ListaEmpleados.ItemsSource = Historial.Models;
        }
        private async void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var d = e.SelectedItem as Nota;

            Debug.WriteLine(d.fecha);
            // await Navigation.PushAsync(pagina);
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            var soundUrl = (string)button.CommandParameter;

            // Create a new instance of the MediaPlayer class
            player = new MediaPlayer();
            player.Reset();
            // Set the source of the audio file using the Source property
            player.SetDataSource(soundUrl);
            player.Prepare();
            player.Start();
        }

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            player.Stop();
        }
    }
}
