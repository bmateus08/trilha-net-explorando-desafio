namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
    }
}

       