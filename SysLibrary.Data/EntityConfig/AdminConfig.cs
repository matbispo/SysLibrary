using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace SysLibrary.Data.EntityConfig
{
    class AdminConfig: EntityTypeConfiguration<Admin>
    {
        public AdminConfig()
        {
            ToTable("Admins");
            HasKey(a=> a.AdminId);
            Property(a => a.emailAdm).IsRequired().HasMaxLength(150);
            Property(a => a.login).IsRequired().HasMaxLength(50);
            Property(a => a.nomeAdm).IsRequired().HasMaxLength(150);
            Property(a => a.senha).IsRequired().HasMaxLength(30);
            Property(a => a.registroFuncionario).IsRequired().HasMaxLength(15);
        }
    }
}
