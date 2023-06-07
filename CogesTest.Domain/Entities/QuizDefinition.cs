using System;
using System.Collections.Generic;
using System.Linq;

namespace CogesTest.Domain.Entities;

public class QuizDefinition
{
    public QuizDefinition() {}


    public QuizDefinition(Guid id)
    {
        Id = id;
    }


    /// <summary>
    ///     A brief description of the quiz
    /// </summary>
    public string Description { get; set; }

    public Guid Id { get; }

    public int QuestionCount => Questions.Count;

    public List<QuizQuestionDefinition> Questions { get; set; } = new();

    /// <summary>
    ///     Quiz's title
    /// </summary>
    public string Title { get; set; }


    public QuizQuestionDefinition GetQuestion(Guid questionId)
    {
        return Questions?.FirstOrDefault(q => q.Id == questionId);
    }
}
