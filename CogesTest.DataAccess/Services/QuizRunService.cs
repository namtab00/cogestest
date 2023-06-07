using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CogesTest.Domain.Entities;
using CogesTest.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace CogesTest.DataAccess.Services;

public class QuizRunService : IQuizRunService
{
    private readonly IDbContextFactory<QuizDbContext> _dbContextFactory;

    private readonly IQuizDefinitionService _quizDefinitionService;


    public QuizRunService(IDbContextFactory<QuizDbContext> dbContextFactory, IQuizDefinitionService quizDefinitionService)
    {
        _dbContextFactory = dbContextFactory;
        _quizDefinitionService = quizDefinitionService;
    }


    /// <inheritdoc />
    public async Task<QuizRun> AddAnswerAsync(Guid quizRunId, Guid quizRunQuestionId, Guid selectedOptionId, CancellationToken ct = default)
    {
        var run = await GetRunAsync(quizRunId, ct) ?? throw new ApplicationException($"quiz run {quizRunId} not found");

        run.AddAnswer(quizRunQuestionId, selectedOptionId);

        await using var context = await _dbContextFactory.CreateDbContextAsync(ct);

        context.Update(run);

        await context.SaveChangesAsync(ct);

        return run;
    }


    /// <inheritdoc />
    public async Task<QuizRun> CreateAsync(string username, Guid quizDefinitionId, CancellationToken ct = default)
    {
        var definition = await _quizDefinitionService.GetDefinitionAsync(quizDefinitionId, ct)
                         ?? throw new ApplicationException($"quiz definition {quizDefinitionId} not found");

        var run = QuizRun.CreateRun(username, definition);

        await using var context = await _dbContextFactory.CreateDbContextAsync(ct);

        context.Add(run);

        await context.SaveChangesAsync(ct);

        return run;
    }


    /// <inheritdoc />
    public async Task DeleteAsync(Guid quizRunId, CancellationToken ct = default)
    {
        var run = await GetRunAsync(quizRunId, ct) ?? throw new ApplicationException($"quiz run {quizRunId} not found");

        await using var context = await _dbContextFactory.CreateDbContextAsync(ct);

        context.Remove(run);

        await context.SaveChangesAsync(ct);
    }


    /// <inheritdoc />
    public async Task<QuizRun> GetRunAsync(Guid quizRunId, CancellationToken ct = default)
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync(ct);

        var run = await context.Runs.Where(qr => qr.Id == quizRunId).FirstOrDefaultAsync(ct);

        return run;
    }
}
