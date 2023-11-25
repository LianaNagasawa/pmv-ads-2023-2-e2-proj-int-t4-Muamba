namespace Muamba.Models
{
    public class AvaliacoesViewModel
    {
        public List<Negociacao> NegociacoesComprador { get; set; }

        public List<Negociacao> NegociacoesViajante { get; set; }

       public List<Avaliacao> AvaliacaoComprador { get; set;}

        public List<Avaliacao> AvaliacaoViajante { get; set; }

        public List<Avaliacao> AvaliacaoEncerrada { get; set; }

        public List<Avaliacao> AvaliacaoEncerradaViajante { get; set; }
    }
}
