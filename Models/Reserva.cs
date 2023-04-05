namespace Desafio_de_Projeto.Models
{
    public class Reserva
    {
        public List<Pessoas> Hospedes { get; set; }
         public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
            
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoas> hospedes)
        {
            int capacidade = 2;
            if (capacidade <= 2)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A quantidade de hospedes não pode exceder a capacidade da suíte.");
            }
        }
        
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
             int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;

            if (DiasReservados < 10)
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }
            else
            {
                valor = DiasReservados * Suite.ValorDiaria;
                decimal desconto = 0.1M * valor;
                valor = valor - desconto;
            }

            return valor;
        }
    }
}
