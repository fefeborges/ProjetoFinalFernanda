using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalFernanda.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código Cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteCpf")]
        [Display(Name = "CPF Cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteSexo")]
        [Display(Name = "Sexo Cliente")]
        public string ClienteSexo { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone Cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço Cliente")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("ClienteNumero")]
        [Display(Name = "Número Cliente")]
        public string ClienteNumero { get; set; } = string.Empty;

        [ForeignKey("Id")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
