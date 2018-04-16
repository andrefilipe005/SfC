using SFC.Models.SFC.Paiis;
using SFC.Models.UserProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFC.Models.Repositorio
{
    public class InstituicaoRepositorio : Repository<Instituicoes>
    {
        public List<Instituicoes> GetInstituicoesAproved()
        {
            return DbSet.Where(a => a.Aproved.Equals(true)).ToList();
        }
        public List<Instituicoes> GetInstituicoesNotAproved()
        {
            return DbSet.Where(a => a.Aproved.Equals(false)).ToList();
        }

        public List<Instituicoes> GetInstituicoesAprovedByName(string name) {
            return DbSet.Where(a => a.Aproved.Equals(true) && a.Nome.ToUpper().Contains(name.ToUpper())).ToList();
        }
        public List<Instituicoes> GetInstituicoesAprovedByConcelho(string name){
            return DbSet.Where(a => a.Aproved.Equals(true) && a.Concelho.ToUpper().Contains(name.ToUpper())).ToList();
        }
        public List<Instituicoes> GetInstituicoesAprovedByFreguesia(string name){
            return DbSet.Where(a => a.Aproved.Equals(true) && a.Freguesia.ToUpper().Contains(name.ToUpper())).ToList();
        }
        public List<Instituicoes> GetInstituicoesNotAprovedByName(string name)
        {
            return DbSet.Where(a => a.Aproved.Equals(false) && a.Nome.ToUpper().Contains(name.ToUpper())).ToList();
        }
        public List<Instituicoes> GetInstituicoesNotAprovedByConcelho(string name)
        {
            return DbSet.Where(a => a.Aproved.Equals(false) && a.Concelho.ToUpper().Contains(name.ToUpper())).ToList();
        }
        public List<Instituicoes> GetInstituicoesNotAprovedByFreguesia(string name)
        {
            return DbSet.Where(a => a.Aproved.Equals(false) && a.Freguesia.ToUpper().Contains(name.ToUpper())).ToList();
        }

    }
}