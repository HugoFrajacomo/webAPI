using Microsoft.EntityFrameworkCore;
using ModeloAPI.Model;


namespace ModeloAPI.InfraData
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Colaborador> Colaboradores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5433;Database=Testecolaboradores" +
            "User Id=postgres;" +
            "Password:8625;");
    }
}
