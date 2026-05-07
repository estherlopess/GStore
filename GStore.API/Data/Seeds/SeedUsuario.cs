using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedUsuario
{
    public class SeedUsuario(ModelBuilder builder)
    {
        #region Perfil
        List<IdentityRole> perfis = [
            new() {
                Id = "72871bd5-9e34-423a-ba7b-f5b5bf311cbc",
                Name = "Administrador",
                NormalizeName ="ADMINISTRADOR"
            },

                 new() {
                Id = "f60f9fd4-9897-4a0d-bf18-8a7ba26d7665",
                Name = "Cliente",
                NormalizeName ="CLIENTE"
            },
        ];
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion

        #region Usuários
        #endregion

        #region Usuário Perfil
        #endregion
    }
}