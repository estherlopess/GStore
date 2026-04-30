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
        
    }
