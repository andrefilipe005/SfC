using SFC.Models.SFC.Paiis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.UserProfiles
{
    public enum Genero
    {
        Feminino = 1,
        Masculino = 2
    }

    [Table("Pai")]
    public class Pais
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PaisID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CivilID { get; set; }

        [Required]
        public string DataNascimento { get; set; }

        [Required]
        public string Nacionalidade { get; set; }

        [Required]
        public string Profissao { get; set; }

        [Required]
        public string Contacto { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public Genero Genero { get; set; }

        public virtual List<Filhos> Filhos { get; set; }

    }
}