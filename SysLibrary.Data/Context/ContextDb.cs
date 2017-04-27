using SysLibrary.Data.EntityConfig;
using SysLibrary.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SysLibrary.Data.Context
{
    public class ContextDb: System.Data.Entity.DbContext
    {
        public ContextDb()
            :base("SysLibraryDB")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          //  base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AdminConfig());
            modelBuilder.Configurations.Add(new AssuntoConfig());
            modelBuilder.Configurations.Add(new AutorConfig());
            modelBuilder.Configurations.Add(new EditoraConfig());
            modelBuilder.Configurations.Add(new EmprestimoConfig());
            modelBuilder.Configurations.Add(new LivroConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
  
        }
    }
}
