using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Livro
    {
        public int livroId { get; set; }
        public string tituto_livro { get; set; }
        public string numero_edicao_livro { get; set; }
        public string quantidade_paginas_livro { get; set; }
        public DateTime ano_publicacao_livro { get; set; }
        public int quantTotal { get; set; }
        public int quantDisponivel { get; set; }
        public Editora editora { get; set; }
        public Assunto assunto { get; set; }
        public ICollection<Autor> autores { get; set; }
        public ICollection<Emprestimo> emprestimos { get; set; }
    }
}
