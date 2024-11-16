namespace MauiAppCadastroDeEventos.Views
{
    public partial class ResumoEvento : ContentPage
    {
        public ResumoEvento()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarEvento());
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InserirEvento());
        }
    }
}