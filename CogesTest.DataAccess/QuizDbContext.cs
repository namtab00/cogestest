using CogesTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CogesTest.DataAccess;

public sealed class QuizDbContext : DbContext
{
    public QuizDbContext(DbContextOptions<QuizDbContext> options)
        : base(options) {}


    public DbSet<QuizDefinition> Definitions { get; set; }

    public DbSet<QuizRun> Runs { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuizDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
