using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysLibrary.Domain.Entities
{
    public class Assunto
    {
        public int Assuntoid { get; set; }
        public string descAssunto { get; set; }
        ICollection<Livro> livros { get; set; }
    }
}
