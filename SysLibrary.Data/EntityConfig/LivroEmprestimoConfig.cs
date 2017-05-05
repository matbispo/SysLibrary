using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.EntityConfig
{
    class LivroEmprestimoConfig:  EntityTypeConfiguration<LivroEmprestimo>
    {
        public LivroEmprestimoConfig()
        {
            ToTable("LivrosEmprestimo");
            HasKey(l => l.livroEmprestimoId);
            Property(l => l.dataDevolucao).IsOptional();
            Property(l => l.devolvido).IsRequired();
        }
    }
}
