using MauiAppCadastroDeEventos.Models;

namespace MauiAppCadastroDeEventos.Views
{
    public partial class InserirEvento : ContentPage
    {
        
        public static List<Evento> ListaEventos = new List<Evento>();

        public InserirEvento()
        {
            InitializeComponent();

            dtpck_inicio.MinimumDate = DateTime.Now;
            dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_fim.MinimumDate = dtpck_inicio.Date.AddDays(1);
            dtpck_fim.MaximumDate = dtpck_inicio.Date.AddMonths(6);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            Evento t = new Evento
            {   
                Nome = nome_evento.Text,
                Participantes = Convert.ToInt32(nmr_participantes.Text),
                CustoParticipante = Convert.ToDouble(cst_participantes.Text),
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_fim.Date,
                Local = local_evento.Text,
                
            };

            ListaEventos.Add(t);

            await Navigation.PushAsync(new ResumoEvento(){

                BindingContext = t

            });

        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarEvento());
        }
    }
}