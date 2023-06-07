using System;
using System.Collections.Generic;
using System.Linq;

namespace CogesTest.Domain.Entities;

public class QuizRunQuestion
{
    public QuizRunQuestion() {}


    public QuizRunQuestion(Guid id)
    {
        Id = id;
    }


    public string Content { get; set; }

    public Guid CorrectOptionId { get; set; }

    public uint DisplayOrder { get; set; }

    public bool HasAnswer => SelectedOptionId.HasValue;

    public bool HasCorrectAnswer { get; set; }

    public Guid Id { get; }

    public int OptionCount => Options.Count;

    public List<QuizQuestionOption> Options { get; set; } = new();

    public Guid QuestionDefinitionId { get; set; }

    public Guid? SelectedOptionId { get; set; }


    /// <summary>
    ///     Marks the quiz run question as answered
    /// </summary>
    public void Answer(Guid selectedOptionId)
    {
        if (HasAnswer)
        {
            throw new ApplicationException($"quiz run question {Id} already has answer {SelectedOptionId}");
        }

        var option = Options.FirstOrDefault(o => o.Id == selectedOptionId)
                     ?? throw new ApplicationException($"option {selectedOptionId} is not a valid option of question {Id}");

        SelectedOptionId = option.Id;

        HasCorrectAnswer = SelectedOptionId == CorrectOptionId;
    }
}
