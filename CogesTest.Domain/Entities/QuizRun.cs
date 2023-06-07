using System;
using System.Collections.Generic;
using System.Linq;

namespace CogesTest.Domain.Entities;

public class QuizRun
{
    public QuizRun(Guid id)
    {
        Id = id;
    }


    /// <summary>
    ///     Whether all <seealso cref="Questions" /> have a correct answer
    /// </summary>
    public bool AllQuestionsAnsweredCorrectly => CorrectAnswersCount == QuestionCount;

    /// <summary>
    ///     Count of <seealso cref="Questions" /> that have an answer
    /// </summary>
    public int AnsweredQuestionsCount => Questions.Count(rq => rq.HasAnswer);

    /// <summary>
    ///     Count of <seealso cref="Questions" /> that have a correct answer
    /// </summary>
    public int CorrectAnswersCount => Questions.Count(rq => rq.HasCorrectAnswer);

    public Guid Id { get; }

    /// <summary>
    ///     A compute progress percent for the quiz run
    /// </summary>
    public uint ProgressPercent {
        get {
            if (AnsweredQuestionsCount == QuestionCount)
            {
                return 100;
            }

            return (uint)Math.Ceiling((((decimal)AnsweredQuestionsCount + 1) / QuestionCount) * 100);
        }
    }

    public int QuestionCount => Questions.Count;

    public List<QuizRunQuestion> Questions { get; set; } = new();

    /// <summary>
    ///     Source quiz definition id
    /// </summary>
    public Guid QuizDefinitionId { get; set; }

    public string Title { get; set; }

    public string Username { get; set; }


    public void AddAnswer(Guid quizRunQuestionId, Guid selectedOptionId)
    {
        var question = GetQuestion(quizRunQuestionId) ?? throw new ApplicationException($"quiz run question {quizRunQuestionId} not found");
        question.Answer(selectedOptionId);
    }


    /// <summary>
    ///     Creates a new <see cref="QuizRun" /> for the provided <paramref name="username" /> from the provided <paramref name="definition" />
    /// </summary>
    public static QuizRun CreateRun(string username, QuizDefinition definition)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ApplicationException($"{nameof(username)} cannot be null or empty");
        }

        var result = new QuizRun(Guid.NewGuid()) {
            QuizDefinitionId = definition.Id,
            Username = username,
            Title = definition.Title
        };
        foreach (var questionDefinition in definition.Questions)
        {
            result.Questions.Add(new QuizRunQuestion(Guid.NewGuid()) {
                QuestionDefinitionId = questionDefinition.Id,
                Content = questionDefinition.Content,
                CorrectOptionId = questionDefinition.CorrectOptionId,
                DisplayOrder = questionDefinition.DisplayOrder,
                HasCorrectAnswer = false,
                Options = questionDefinition.Options,
                SelectedOptionId = null
            });
        }

        return result;
    }


    public (QuizRunQuestion NextQuestion, uint? nextQuestionIndex) GetNextQuestion()
    {
        var orderedQuestions = Questions.OrderBy(q => q.DisplayOrder).ToList();

        var nextQuestion = orderedQuestions.FirstOrDefault(q => !q.HasAnswer);
        if (nextQuestion == null)
        {
            return (null, null);
        }

        return (nextQuestion, (uint)orderedQuestions.IndexOf(nextQuestion));
    }


    public QuizRunQuestion GetQuestion(Guid questionId)
    {
        return Questions?.FirstOrDefault(q => q.Id == questionId);
    }


    public QuizRunQuestion GetQuestionByDefinitionId(Guid questionDefinitionId)
    {
        return Questions?.FirstOrDefault(q => q.QuestionDefinitionId == questionDefinitionId);
    }


    public bool IsLastQuestion(QuizRunQuestion question)
    {
        if (question == null)
        {
            return false;
        }

        var lastQuestion = Questions.OrderByDescending(q => q.DisplayOrder).First();
        return question.Id == lastQuestion.Id;
    }
}
