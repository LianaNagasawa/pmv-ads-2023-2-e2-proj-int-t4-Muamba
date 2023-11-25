using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMuamba.Models

{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor informar o cpf.")]
        public long Cpf { get; set; }

        [Required(ErrorMessage = "Favor informar o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor informar o e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Favor informar a senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Favor informar a data de nascimento.")]
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        [Required(ErrorMessage = "Favor informar a cidade.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Favor informar o estado.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Favor informar o telefone.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Favor adicionar uma foto.")]
        public string Foto { get; set; }

        public int? MediaAvaliacao { get; set; }
    }
}

