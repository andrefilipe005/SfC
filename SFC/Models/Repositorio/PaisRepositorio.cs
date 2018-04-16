using SFC.Models.UserProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFC.Models.Repositorio
{
    public class PaisRepositorio : Repository<Pais>
    {
        public List<Pais> GetByName(String name)
        {
            return DbSet.Where(a => a.Name.Contains(name)).ToList();
        }
        public List<Pais> GetPaisByName(string name)
        {
            return DbSet.Where(a => a.Name.ToUpper().Contains(name.ToUpper())).ToList();
        }
        public List<Pais> GetPaisByCivilID(string civilID)
        {
            return DbSet.Where(a => a.CivilID.ToUpper().Contains(civilID.ToUpper())).ToList();
        }
        public List<Pais> GetPaisByContacto(string contacto)
        {
            return DbSet.Where(a => a.Contacto.ToUpper().Contains(contacto.ToUpper())).ToList();
        }


    }
}