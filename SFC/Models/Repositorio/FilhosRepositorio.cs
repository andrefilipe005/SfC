using SFC.Models.SFC.Paiis;
using SFC.Models.UserProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFC.Models.Repositorio
{
    public class FilhosRepositorio : Repository<Filhos>
    {
        public List<Filhos> GetFilhosByNome(string name) {
            return DbSet.Where(f => f.Name.ToUpper().Contains(name.ToUpper())).ToList();
        }
        public List<Filhos> GetFilhosByPaiNome(string pai)
        {
            return DbSet.Where(f => f.Pai.Name.ToUpper().Contains(pai.ToUpper())).ToList();
        }
        public List<Filhos> GetFilhosByCivilID(string civilID)
        {
            return DbSet.Where(f => f.CivilID.ToUpper().Contains(civilID.ToUpper())).ToList();
        }
        public List<Filhos> GetFilhosByDataDeNascimento(string dtn)
        {
            string type_date = dtn.Substring(2,1);
            if (!type_date.Equals("/") && !type_date.Equals("-") && !type_date.Equals(":")){
                type_date = dtn.Substring(1, 1);
                if (!type_date.Equals("/") && !type_date.Equals("-") && !type_date.Equals(":"))                {
                    type_date = "-";
                }
            }
            var teste = dtn.Replace(type_date, "-");
            return DbSet.Where(f =>
            f.DataNascimento.Equals(dtn.Replace(type_date, "-")) ||
            f.DataNascimento.Equals(dtn.Replace(type_date, "/")) ||
            f.DataNascimento.Equals(dtn.Replace(type_date, ":"))).ToList();
        }
        public List<Filhos> GetFilhosByNacionalidade(string nacionalidade)
        {
            return DbSet.Where(f => f.Nacionalidade.ToUpper().Contains(nacionalidade.ToUpper())).ToList();
        }
        public List<Filhos> GetFilhosByConcelho(string concelho)
        {
            return DbSet.Where(f => f.Concelho.ToUpper().Contains(concelho.ToUpper())).ToList();
        }
        public List<Filhos> GetFilhosByFreguesia(string freguesia)
        {
            return DbSet.Where(f => f.Freguesia.ToUpper().Contains(freguesia.ToUpper())).ToList();
        }
    }
}