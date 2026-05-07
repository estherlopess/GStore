using System.Security.Principal;
using GStore.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameWorkCore;


namespace GStore.API.Data;

    public class AppDbContext : IdentityDbContext<Ususario>
{
        public AppContext(AppDbContextOptions<AppDbContext>options) : base (options)
    {
    }

    public Dbset<Categoria> Categorias { get; set;}
    public Dbset<Produto> Produtos { get; set; }
    public DbSet <Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    base.OnModelCreating(builder);
      
      #region Configuração do Identity
      builder.Entity<Usuarios>().ToTable("usuarios");
      builder.Entity<IdentityRole>().ToTable("perfis");
      builder.Entity<IdentityUserRole<string>>().ToTable("usuario_perfis");
      builder.Entity<IdentityUserToken<string>().ToTable("usuario_tokens");
      builder.Entity<IdentityUserLogin<string>().ToTable("ususario_logins");
      builder.Entity<IdentityUserClaim<string>>().ToTable("usuario_regras");
      builder.Entity<IdentityRoleClaim<string>>().ToTable("Perfil_regras");
      #endregion
    }

}
