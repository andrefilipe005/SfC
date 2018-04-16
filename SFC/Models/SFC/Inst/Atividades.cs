using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.SFC.Inst
{
    [Table("Atividades")]
    public class Atividades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AtividadeID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime InicioAtividade { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FimAtividade { get; set; }

        [ForeignKey("Detalhe")]
        public Guid DetalheID { get; set; }
        public virtual Detalhe Detalhe { get; set; }
    }
}