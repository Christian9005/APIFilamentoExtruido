using APIFilamentoExtruido.Domain;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace APIFilamentoExtruido.Context;

public class FDbContext : DbContext
{
    public FDbContext(DbContextOptions<FDbContext> options) : base(options)
    {
    }

    public DbSet<ExtrudedFilament> ExtrudedFilaments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new NpgsqlConnectionStringBuilder
        {
            Host = "containers-us-west-63.railway.app",
            Port = 7223,
            Database = "railway",
            Username = "postgres",
            Password = "gydcBqKM0kBEyzhe4ueo",
        };

        string connectionString = builder.ConnectionString;

        optionsBuilder.UseNpgsql(connectionString);
    }
}
