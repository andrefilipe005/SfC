using SFC.Models.UserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.SFC.Inst
{

    [Table("Detalhe")]
    public class Detalhe
    {
        [Key , ForeignKey("Instituicao")]
        public Guid DetalheID { get; set; }
        public string Missao { get; set; }
        public string Visao { get; set; }
        public string Historia { get; set; }
        public virtual Instituicoes Instituicao { get; set; }
        public virtual List<Atividades> Atividades { get; set; }
    }
}