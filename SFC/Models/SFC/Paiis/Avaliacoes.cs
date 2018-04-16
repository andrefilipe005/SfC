using SFC.Models.UserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.SFC.Paiis
{
    [Table("Avaliacao")]
    public class Avaliacoes
    {
        [Key]
        public Guid AvaliacaoID { get; set; }

        [ForeignKey("Instituicao")]
        public Guid InstituicaoID { get; set; }

        [ForeignKey("Pais")]
        public Guid PaiID { get; set; }

        [ForeignKey("Filho")]
        public Guid FilhoID { get; set; }
        [Required]
        public int Nota { get; set; }
        public string Critica { get; set; }

        public virtual Filhos Filho { get; set; }
        public virtual Instituicoes Instituicao { get; set; }
        public virtual Pais Pais { get; set; }

    }
}