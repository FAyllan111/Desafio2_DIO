namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() {
            Hospedes = new List<Pessoa>();
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
            {
                throw new Exception("Nenhuma suite foi cadastrada");
            }

            if(Hospedes == null || Hospedes.Count == 0)
            {
                throw new Exception("Não foram cadastrados hospedes");
            }

            if (Hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {

                throw new Exception("A quantidade de hospedes é maior que a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            if(Hospedes != null)
            {
                return Hospedes.Count;
            }
            return 0;           

        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.10m);
            }

            return valor;
        }
    }
}