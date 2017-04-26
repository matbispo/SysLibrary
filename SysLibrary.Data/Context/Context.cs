using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLibrary.Data.Context
{
    class Context: DbContext
    {
        public Context()
            :base("SysLibraryDB")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        // dbsets  public DbSet<entity> nameEntity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          //  base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // modelBuilder.Configurations.Add(new entityfiguration());
        }
    }
}
