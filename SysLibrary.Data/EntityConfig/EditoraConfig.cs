using System;
using SysLibrary.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.EntityConfig
{
    class EditoraConfig : EntityTypeConfiguration<Editora>
    {
        public EditoraConfig()
        {
            ToTable("Editoras");
            HasKey(e => e.editoraId);
            Property(e => e.descEditora).IsRequired().HasMaxLength(100);

        }
    }
}
