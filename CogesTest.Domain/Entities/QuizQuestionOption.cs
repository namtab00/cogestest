using System;

namespace CogesTest.Domain.Entities;

public class QuizQuestionOption
{

    public QuizQuestionOption(Guid id)
    {
        Id = id;
    }


    /// <summary>
    ///     The textual content of the question option
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    ///     The order in which the question option should be displayed
    /// </summary>
    public uint DisplayOrder { get; set; }

    public Guid Id { get; }
}
