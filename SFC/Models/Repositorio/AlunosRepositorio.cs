using SFC.Models.SFC.Inst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFC.Models.Repositorio
{
    public class AlunosRepositorio : Repository<Alunos>
    {
        public List<Alunos> GetAlunosByIdInstituicao(Guid id) {
            return DbSet.Where(i => i.InstituicaoID.Equals(id)).ToList();
        }
    }
}