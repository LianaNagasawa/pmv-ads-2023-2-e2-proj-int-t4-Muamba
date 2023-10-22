namespace Muamba.Models
{
    public class BuscaViajanteViewModel
    {
        public int UsuarioId { get; set; }
        public string ResultadoBuscaViajante { get; set; }

        public List<Viagem> Viagens { get; set; }

        public Produto Produto { get; set; }
    }
}
