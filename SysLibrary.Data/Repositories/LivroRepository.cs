using SysLibrary.Domain.Entities;
using SysLibrary.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.Repositories
{
    class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> buscarAssunto(string assunto)
        {
            return db.Livros.ToList().Where(a => a.assunto.descAssunto == assunto);
        }

        public IEnumerable<Livro> buscarAutor(string autor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> buscarTitulo(string titulo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> listarDisponiveis()
        {
            throw new NotImplementedException();
        }
    }
}
