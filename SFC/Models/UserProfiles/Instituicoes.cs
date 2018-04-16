using SFC.Models.SFC.Inst;
using SFC.Models.SFC.Paiis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.UserProfiles
{
    public enum TipoInstituicao
    {
        Privado = 1,
        Publico = 2
    }

    [Table("Instituicao")]
    public class Instituicoes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid InstituicaoID { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Concelho { get; set; }

        [Required]
        public string Freguesia { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public TipoInstituicao TipoInstituicao { get; set; }

        [Required]
        public bool Aproved { get; set; }

        public virtual Detalhe Detalhe { get; set; }
        public virtual List<TipoEnsino> TipoEnsino { get; set; }

        public virtual List<RegistoFilhos> PedidoRegisto { get; set; }
        public virtual List<Alunos> Alunos { get; set; }

        public virtual List<Avaliacoes> Avaliacoes { get; set; }

    }
}