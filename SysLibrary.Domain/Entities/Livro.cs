﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Domain.Entities
{
    public class Livro
    {
        public int livroId { get; set; }
        public string titutoLivro { get; set; }
        public string numeroEdicao { get; set; }
        public string quantidadePaginas{ get; set; }
        public DateTime anoPublicacao{ get; set; }
        public string idioma { get; set; }
        public int quantTotal { get; set; }
        public int quantDisponivel { get; set; }
        public Editora editora { get; set; }
        public Assunto assunto { get; set; }

        // usar a anotação virtual para gerar o lazy load nos relacionamentos

        public ICollection<Autor> autores { get; set; }
        public ICollection<Emprestimo> emprestimos { get; set; }
    }
}
