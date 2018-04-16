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
    public enum EstadoAproved
    {
        Aceite = 1,
        Pendente = 2,
        Recusado = 3
    }

    [Table("RegistoFilhos")]
    public class RegistoFilhos
    {
        [Key]
        public Guid RegistoID { get; set; }
        [ForeignKey("Filhos")]
        public Guid FilhoID { get; set; }
        [ForeignKey("Instituicao")]
        public Guid InstituicaoID { get; set; }
        [Required]
        public EstadoAproved Aproved { get; set; }
        public virtual Filhos Filhos { get; set; }
        public virtual Instituicoes Instituicao { get; set; }
    }
}