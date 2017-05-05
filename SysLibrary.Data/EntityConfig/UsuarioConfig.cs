using SysLibrary.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.EntityConfig
{
    class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            ToTable("Usuarios");
            HasKey(u => u.UsuarioId);
            Property(u => u.nome).IsRequired().HasMaxLength(150);
            Property(u => u.email).IsRequired().HasMaxLength(150);
            Property(u => u.cpf).IsRequired().HasMaxLength(20);
            Property(u => u.celular).IsRequired().HasMaxLength(15);
            Property(u => u.data_nasc).IsRequired();
            Property(u => u.elegivelEmprestimo).IsRequired();
            Property(u => u.sexo).IsRequired().HasMaxLength(1);
            Property(u => u.telefone).IsRequired().HasMaxLength(15);
            Property(u => u.senha).IsRequired().HasMaxLength(50);
            
        }
    }
}
