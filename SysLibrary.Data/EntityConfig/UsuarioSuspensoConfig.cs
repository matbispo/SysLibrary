using SysLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.EntityConfig
{
    class UsuarioSuspensoConfig : EntityTypeConfiguration<UsuarioSuspenso>
    {
        public UsuarioSuspensoConfig()
        {
            ToTable("UsuariosSuspensos");
            HasKey(u => u.usuarioSuspensoId);
            Property(u => u.ativoSuspenso).IsRequired();
            Property(u => u.dataSuspensao).IsRequired();
            Property(u => u.quantDiaSuspenso).IsRequired();

        }
    }
}
