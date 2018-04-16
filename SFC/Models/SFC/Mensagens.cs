using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SFC.Models.SFC
{
    [Table("Mensagens")]
    public class Mensagens
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MensagemID { get; set; }
        [Required]
        public Guid SenderID { get; set; }
        [Required]
        public Guid ReceiverID { get; set; }
        [Required]
        public string Assunto { get; set; }
        [Required]
        public string Mensagem { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataEnvio { get; set; }
        [Required]
        public bool Vista { get; set; }
    }
}