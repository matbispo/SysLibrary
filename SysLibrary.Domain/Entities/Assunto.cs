using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Assunto
    {
        public int id { get; set; }
        public String desc_assunto { get; set; }
        ICollection<Livro> livros { get; set; }
    }
}
