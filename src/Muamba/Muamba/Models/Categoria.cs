using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muamba.Models
{
    [Table("tbCategoria")]
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new List<Produto>();
        }

        [Key]
        public int Id { get; set; }

        public String Nome { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
