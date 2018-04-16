using SFC.Models.UserProfiles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.SFC.Paiis
{
    [Table("Filhos")]
    public class Filhos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid FilhoID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CivilID { get; set; }
        [Required]
        public string DataNascimento { get; set; }
        [Required]
        public Genero Genero { get; set; }
        [Required]
        public string EstadoCivil { get; set; }
        [Required]
        public string Nacionalidade { get; set; }
        [Required]
        public string Concelho { get; set; }
        [Required]
        public string Freguesia { get; set; }
        [Required]
        public string Endereço { get; set; }

        [ForeignKey("Pai")]
        public Guid PaisID { get; set; }
        public virtual Pais Pai { get; set; }
        public virtual Instituicoes Instituicao { get; set; }
    }
}