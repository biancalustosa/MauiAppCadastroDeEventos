namespace MauiAppCadastroDeEventos.Views
{
    public partial class CadastrarEvento : ContentPage
    {
        public CadastrarEvento()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InserirEvento());
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new ListarEventos()); 
        }

    }
}