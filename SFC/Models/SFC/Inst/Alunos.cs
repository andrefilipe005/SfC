using SFC.Models.SFC.Paiis;
using SFC.Models.UserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.SFC.Inst
{
    [Table("Alunos")]
    public class Alunos
    {
        [Key, ForeignKey("Filhos")]
        public Guid AlunosID { get; set; }
        [ForeignKey("Instituicao")]
        public Guid InstituicaoID { get; set; }
        [Required]
        public DateTime DataDeRegisto { get; set; }

        public virtual Filhos Filhos { get; set; }
        public virtual Instituicoes Instituicao { get; set; }
    }
}