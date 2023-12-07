using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalFernanda.Models
{
    [Table("ProcedimentoRealizado")]
    public class ProcedimentoRealizado
    {
        [Column("Id")]
        [Display(Name = "Código Procedimento Realizado")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("Id")]
        public int? ProcedimentoId { get; set; }
        public Procedimento? Procedimento { get; set; }

        [ForeignKey("Id")]
        public int? ColaboradorId { get; set; }
        public Colaborador? Colaborador { get; set; }

        [ForeignKey("Id")]
        public int? LocalRealizacaoId { get; set; }
        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data de Realização")]
        public DateTime DataRealizacao { get; set;  }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;

    }
}

        