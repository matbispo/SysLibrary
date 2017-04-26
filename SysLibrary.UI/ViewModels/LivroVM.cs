using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysLibrary.UI.ViewModels
{
    public class LivroVM
    {
        public int livroId { get; set; }

        public string tituto_livro { get; set; }
        public string numero_edicao_livro { get; set; }
        public String quantidade_paginas_livro { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime ano_publicacao_livro { get; set; }
        public int quantTotal { get; set; }
        public int quantDisponivel { get; set; }
        public Editora editora { get; set; }
        public Assunto assunto { get; set; }
        public ICollection<Autor> autores { get; set; }
        public ICollection<Emprestimo> emprestimos { get; set; }
    }
}