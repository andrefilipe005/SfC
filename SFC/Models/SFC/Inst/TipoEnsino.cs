using SFC.Models.UserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.SFC.Inst
{
    /*public enum TipoDeEnsino{
    Creche = 1,
    PreEscola = 2,
    BasicoPrimeiroCiclo = 3,
    BasicoSegundoCiclo = 4,
    BasicoTerceiroCiclo = 5,
    Secundario = 6,
    Superior = 7
    }*/

    [Table("TipoEnsino")]
    public class TipoEnsino
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TipoEnsinoID { get; set; }
        [Required]
        public string Nome { get; set; }
        [NotMapped]
        public bool Selected { get; set; }
        [ForeignKey("Instituicao")]
        public Guid InstituicaoID { get; set; }
        public virtual Instituicoes Instituicao { get; set; }
    }

    
}