using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalFernanda.Models
{
    [Table ("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código Usuario")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Usuário")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email")]
        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
