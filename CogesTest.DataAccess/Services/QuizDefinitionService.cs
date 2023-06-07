using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CogesTest.Domain.Entities;
using CogesTest.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace CogesTest.DataAccess.Services;

public class QuizDefinitionService : IQuizDefinitionService
{
    private readonly IDbContextFactory<QuizDbContext> _dbContextFactory;


    public QuizDefinitionService(IDbContextFactory<QuizDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }


    /// <inheritdoc />
    public async Task<List<QuizDefinition>> FetchAllDefinitionsAsync(CancellationToken ct = default)
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync(ct);

        var allDefinitions = await context.Definitions.OrderBy(qd => qd.Title).ToListAsync(ct);

        return allDefinitions;
    }


    /// <inheritdoc />
    public async Task<QuizDefinition> GetDefinitionAsync(Guid definitionId, CancellationToken ct = default)
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync(ct);

        var definition = await context.Definitions.Where(qd => qd.Id == definitionId).FirstOrDefaultAsync(ct);

        return definition;
    }
}
