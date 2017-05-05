using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.Repositories
{
    class AutorRepository : RepositoryBase<Autor>, IAutorRepository
    {
        public IEnumerable<Autor> buscarAutor(string autor)
        {
            return db.Autores.ToList().Where(a => a.nomeAutor == autor);
        }
    }
}
