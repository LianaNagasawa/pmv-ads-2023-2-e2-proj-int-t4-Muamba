using SiteMuamba.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muamba.Models
{
    [Table("tbNegociacao")]
    public class Negociacao
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CompradorId")]
        public Usuario Comprador { get; set; }
        public int CompradorId { get; set; }


        [ForeignKey("ViagemId")]
        public Viagem Viagem { get; set; }
        public int ViagemId { get; set; }


        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public int Status { get; set; }

    }
}
