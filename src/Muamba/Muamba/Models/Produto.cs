using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muamba.Models
{
    [Table("tbProduto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir Nome do produto")]
        public String Nome { get; set; }

        [Required(ErrorMessage ="Obrigatório inserir Palavra-Chave do produto")]
        public String PalavraChave { get; set; }

        public String? FotoProduto { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Informe a categoria.")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        public bool Status { get; set; }

    }
}
