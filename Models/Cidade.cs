using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalFernanda.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Código Cidade")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Cidade")]
        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("Id")]
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
    }
}
