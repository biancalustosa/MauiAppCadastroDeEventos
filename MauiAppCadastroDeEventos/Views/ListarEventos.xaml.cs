namespace MauiAppCadastroDeEventos.Views
{
    public partial class ListarEventos : ContentPage
    {
        
        public ListarEventos()
        {
            InitializeComponent();

            BindingContext = this;

            EventosListView.ItemsSource = InserirEvento.ListaEventos;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarEvento());
        }
    }
}