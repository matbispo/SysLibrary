using System;
using SysLibrary.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.EntityConfig
{
    class LivroConfig : EntityTypeConfiguration<Livro>
    {
        public LivroConfig()
        {
            ToTable("Livros");
            HasKey(l => l.livroId);
            Property(l => l.idioma).IsRequired().HasMaxLength(100);
            Property(l => l.numeroEdicao).IsRequired().HasMaxLength(100);
            Property(l => l.quantDisponivel).IsRequired();
            Property(l => l.quantidadePaginas).IsRequired().HasMaxLength(5);
            Property(l => l.titutoLivro).IsRequired().HasMaxLength(150);
            Property(l => l.quantTotal).IsRequired();
            Property(l => l.anoPublicacao).IsRequired();
        }
    }
}
