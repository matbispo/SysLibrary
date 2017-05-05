using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.Repositories
{
    class EditoraRepository : RepositoryBase<Editora>, IEditoraRepository
    {
        public IEnumerable<Editora> buscarEditora(string editora)
        {
            return db.Editoras.ToList().Where(e => e.descEditora  == editora);
        }
    }
}
