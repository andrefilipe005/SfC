using SFC.Models.SFC.Inst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFC.Models.Repositorio
{
    public class DetalheRepositorio : Repository<Detalhe>
    {
        public Detalhe GetDetalheByInstituicao(Guid id)
        {
            return (Detalhe) DbSet.Where(d => d.DetalheID.Equals(id));
        }
    }
}