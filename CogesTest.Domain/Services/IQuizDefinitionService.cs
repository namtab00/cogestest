using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CogesTest.Domain.Entities;

namespace CogesTest.Domain.Services;

public interface IQuizDefinitionService
{
    /// <summary>
    ///     Returns all available <see cref="QuizDefinition" />s
    /// </summary>
    Task<List<QuizDefinition>> FetchAllDefinitionsAsync(CancellationToken ct = default);


    /// <summary>
    ///     Returns a <see cref="QuizDefinition" /> identified by the provided <paramref name="definitionId" />
    /// </summary>
    Task<QuizDefinition> GetDefinitionAsync(Guid definitionId, CancellationToken ct = default);
}
