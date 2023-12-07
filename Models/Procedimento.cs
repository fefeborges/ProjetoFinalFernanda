using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalFernanda.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Código Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação do Procedimento")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("Id")]
        public int TipoProcedimentoId { get; set; }
        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}
