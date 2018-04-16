using SFC.Models.SFC.Paiis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFC.Models.Repositorio
{
    public class AvaliacoesRepositorio : Repository<Avaliacoes>
    {
        public List<Avaliacoes> GetAvaliacoesByIdInstituicao(Guid id)
        {
            return DbSet.Where(i => i.InstituicaoID.Equals(id)).ToList();
        }

        public Avaliacoes GetAvaliacaoByIdFilho(Guid id)
        {
            try{
                return DbSet.Where(i => i.FilhoID.Equals(id)).First();
            }catch(Exception ex){
                return null;
            }
        }
    }
}