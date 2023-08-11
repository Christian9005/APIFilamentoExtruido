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
        string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("DB_CONNECTION_STRING environment variable is not set.");
            }

        optionsBuilder.UseNpgsql(connectionString);
    }
}
