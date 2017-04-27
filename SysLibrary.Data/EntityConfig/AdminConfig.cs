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

        }
    }
}
