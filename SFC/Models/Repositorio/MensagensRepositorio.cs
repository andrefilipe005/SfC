using SFC.Models.SFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFC.Models.Repositorio
{
    public class MensagensRepositorio : Repository<Mensagens>
    {
        public List<Mensagens> GetMensagens(Guid id) {
            return DbSet.Where(m => m.ReceiverID.Equals(id)).ToList();
        }
        public List<Mensagens> GetMensagensVistas(Guid id)
        {
            return DbSet.Where(m => m.ReceiverID.Equals(id) && m.Vista.Equals(true)).ToList();
        }
        public int NumeroDeNovasMensagens(Guid id)
        {
            return DbSet.Where(m => m.ReceiverID.Equals(id) && m.Vista.Equals(false)).Count();
        }
        public List<Mensagens> GetMensagensNaoVistas(Guid id)
        {
            return DbSet.Where(m => m.ReceiverID.Equals(id) && m.Vista.Equals(false)).ToList();
        }

    }
}