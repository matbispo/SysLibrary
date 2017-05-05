using System;
using SysLibrary.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.EntityConfig
{
    class EmprestimoConfig : EntityTypeConfiguration<Emprestimo>
    {
        public EmprestimoConfig()
        {
            ToTable("Emprestimos");
            HasKey(e => e.emprestimoId);
            Property(e => e.dataEmprestimo).IsRequired();
            Property(e => e.dataPrevistaDevolucao).IsRequired();
            Property(e => e.status).IsRequired().HasMaxLength(20);
        }
    }
}
