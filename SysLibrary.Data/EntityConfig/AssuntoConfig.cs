﻿using System;
using SysLibrary.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.EntityConfig
{
    class AssuntoConfig : EntityTypeConfiguration<Assunto>
    {
        public AssuntoConfig()
        {
            ToTable("Assuntos");
            HasKey(a=> a.Assuntoid);
            Property(a => a.descAssunto).IsRequired().HasMaxLength(30);


        }
    }
}
