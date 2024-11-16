namespace MauiAppCadastroDeEventos.Models
{
    public class Evento
    {
        public string? Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int Participantes { get; set; }
        public string? Local { get; set; }
        public double CustoParticipante { get; set; }

        public int DuracaoEvento{
             get => DataTermino.Subtract(DataInicio).Days;
        }

        public double CustoTotal{
            get{
                double CustoEvento = Participantes * CustoParticipante;

                return CustoEvento;
            }
        }
    }
}