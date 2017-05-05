using System;
using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.Repositories
{
    class AssuntoRepository : RepositoryBase<Assunto>, IAssuntoRepository
    {
        public IEnumerable<Assunto> buscarAssunto(string assunto)
        {
            return db.Assuntos.ToList().Where(a=> a.descAssunto == assunto);
        }
    }
}
