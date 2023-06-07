using System;
using System.Collections.Generic;

namespace CogesTest.Domain.Entities;

public class QuizQuestionDefinition
{
    public QuizQuestionDefinition() {}


    public QuizQuestionDefinition(Guid id)
    {
        Id = id;
    }


    /// <summary>
    ///     The textual content of the question
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    ///     The id of the correct <see cref="QuizQuestionOption" /> in <seealso cref="Options" />
    /// </summary>
    public Guid CorrectOptionId { get; set; }

    /// <summary>
    ///     The order in which the quiz question should be displayed
    /// </summary>
    public uint DisplayOrder { get; set; }

    public Guid Id { get; }

    public int OptionCount => Options.Count;

    public List<QuizQuestionOption> Options { get; set; }
}
