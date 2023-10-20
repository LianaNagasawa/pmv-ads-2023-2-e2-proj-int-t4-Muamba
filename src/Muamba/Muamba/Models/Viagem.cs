using SiteMuamba.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muamba.Models

{
    [Table("tbViagem")]
    public class Viagem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UsuarioViajanteId")]
        public Usuario UsuarioViajante { get; set; }

        public int UsuarioViajanteId { get; set; }

        public string Regiao { get; set; }

        public string Pais { get; set; }

        public string Provincia { get; set; }

        public DateTime DataIda { get; set; }

        public DateTime DataVolta { get; set; }

       
    }
}
