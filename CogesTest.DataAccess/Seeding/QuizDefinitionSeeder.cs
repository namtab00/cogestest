using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using CogesTest.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CogesTest.DataAccess.Seeding;

public class QuizDefinitionSeeder
{
    private readonly QuizDbContext _dbContext;

    private readonly ILogger<QuizDefinitionSeeder> _logger;


    public QuizDefinitionSeeder(IServiceProvider serviceProvider)
    {
        _dbContext = serviceProvider.GetService<QuizDbContext>();
        _logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger<QuizDefinitionSeeder>();
    }


    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    private static IReadOnlyList<QuizDefinition> QuizDefinitionsToSeed =>
        new List<QuizDefinition> {
            SampleQuizzes.MovieQuiz,
            SampleQuizzes.BiologyQuiz,
            SampleQuizzes.GeographyQuiz,
            SampleQuizzes.ScienceQuiz,
            SampleQuizzes.ChemistryQuiz
        };


    /// <summary>
    ///     Creates the database and seed all quizzes from <seealso cref="QuizDefinitionsToSeed" /> if not already seeded.
    /// </summary>
    public void Seed()
    {
        _dbContext.Database.EnsureCreated();

        _logger.LogInformation($"seeding {QuizDefinitionsToSeed.Count} quizzes");

        var dbSet = _dbContext.Definitions;

        foreach (var quizDefinition in QuizDefinitionsToSeed)
        {
            var alreadySeededQuiz = dbSet.FirstOrDefault(c => c.Id == quizDefinition.Id);
            if (alreadySeededQuiz != null)
            {
                _logger.LogInformation($"quiz {quizDefinition.Id} '{quizDefinition.Title}' already seeded, skipping");
                continue;
            }

            dbSet.Add(quizDefinition);
        }

        _dbContext.SaveChanges();
    }
}
