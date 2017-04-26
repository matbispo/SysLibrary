using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    class Editora
    {
        public int id { get; set; }
        public string desc_editora { get; set; }
        ICollection<Livro> livros { get; set; }
    }
}
