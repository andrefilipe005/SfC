using SFC.Models.SFC.Inst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFC.Models.Repositorio
{
    public class RegistoFilhosRepositorio : Repository<RegistoFilhos>
    {
        public List<RegistoFilhos> GetRegistoFilhosByInsituicaoID (Guid id) {
            return DbSet.Where(i => i.InstituicaoID.Equals(id)).ToList();
        }
        public RegistoFilhos GetRegistoFilhosByFilhoID(Guid idFilho, Guid idInsti)
        {
            RegistoFilhos registoFilhos = new RegistoFilhos();
            try{
                registoFilhos = DbSet.Where(i => i.FilhoID.Equals(idFilho) && i.InstituicaoID.Equals(idInsti)).First();
            }
            catch (Exception ex) {
                registoFilhos = null;
            }
            return registoFilhos;
        }
        public List<RegistoFilhos> GetRegistoFilhosByFilhoID(Guid id)
        {
            return DbSet.Where(i => i.FilhoID.Equals(id)).ToList();
        }
    }
}