using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysLibrary.UI.ViewModels
{
    public class EmprestimoVM
    {
        public int id { get; set; }
        public Usuario usuario { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime dataInicio { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? dataTermino { get; set; }
        public string status { get; set; }
        public ICollection<Livro> livros { get; set; }
    }
}