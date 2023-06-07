using System;
using System.Threading;
using System.Threading.Tasks;
using CogesTest.Domain.Entities;

namespace CogesTest.Domain.Services;

public interface IQuizRunService
{
    /// <summary>
    ///     Adds an answer to a <see cref="QuizRun" /> and saves it
    /// </summary>
    Task<QuizRun> AddAnswerAsync(Guid quizRunId, Guid quizRunQuestionId, Guid selectedOptionId, CancellationToken ct = default);


    /// <summary>
    ///     Creates a <see cref="QuizRun" /> from the provided <paramref name="quizDefinitionId" />, saves and returns it
    /// </summary>
    Task<QuizRun> CreateAsync(string username, Guid quizDefinitionId, CancellationToken ct = default);


    /// <summary>
    ///     Deletes a <see cref="QuizRun" /> identified by the provided <paramref name="quizRunId" />
    /// </summary>
    Task DeleteAsync(Guid quizRunId, CancellationToken ct = default);


    /// <summary>
    ///     Returns a <see cref="QuizRun" /> identified by the provided <paramref name="quizRunId" />
    /// </summary>
    Task<QuizRun> GetRunAsync(Guid quizRunId, CancellationToken ct = default);
}
