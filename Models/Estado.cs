﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalFernanda.Models
{
    [Table ("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Código Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Estado")]
        public string EstadoNome { get; set; } = string.Empty;
    }
}
