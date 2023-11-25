using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muamba.Models
{
    [Table("tbAvaliacao")]
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("NegociacaoId")]
        public Negociacao Negociacao { get; set; }
        public int NegociacaoId { get; set; }

        public int? NotaComprador { get; set; }

        public int? NotaViajante { get; set; }


    }
}
