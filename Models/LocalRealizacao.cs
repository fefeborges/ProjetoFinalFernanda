using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalFernanda.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Código Local de Realização")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Local de Realização")]
        public string LocalNome { get; set; } = string.Empty;

        [ForeignKey("Id")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
