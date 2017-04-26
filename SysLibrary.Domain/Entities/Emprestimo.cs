using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    class Emprestimo
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime? dataTermino { get; set; }
        public string status { get; set; }
        public ICollection<Livro> livros { get; set; }
    }
}
