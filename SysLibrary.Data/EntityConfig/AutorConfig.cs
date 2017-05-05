using System;
using SysLibrary.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.EntityConfig
{
    class AutorConfig : EntityTypeConfiguration<Autor>
    {
        public AutorConfig()
        {
            ToTable("Autores");
            HasKey(a => a.autorId);
            Property(a => a.nomeAutor).IsRequired().HasMaxLength(100);

        }
    }
}
