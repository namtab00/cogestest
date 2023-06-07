using System;
using System.Collections.Generic;
using System.Linq;
using CogesTest.Domain.Entities;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace CogesTest.Domain.Tests.Entities;

public class QuizRunTests
{
    public QuizRunTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }


    private readonly ITestOutputHelper _outputHelper;

    private const string TestUsername = "test username";

    private static QuizDefinition TestQuizDefinition =>
        new(new Guid("64C9C4A0-FDAE-45A6-8288-2BC37DCFD946")) {
            Description = "Test definition description",
            Title = "Test quiz title",
            Questions = new List<QuizQuestionDefinition> {
                new(new Guid("E5D18A4D-5005-402F-AAF0-C41241FD5E1C")) {
                    Content = "Question 1",
                    CorrectOptionId = new Guid("5F490DB3-5632-47F4-B046-91A988BFE2A9"),
                    DisplayOrder = 0,
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("C3328B7A-D467-4660-A3D3-0ADE3789FAB3")) {
                            Content = "Answer 1",
                            DisplayOrder = 0
                        },
                        new(new Guid("1F042E9D-9B66-4D8C-884A-E2DC09168331")) {
                            Content = "Answer 2",
                            DisplayOrder = 1
                        },
                        new(new Guid("2D48E703-28AF-45D2-9AD9-9004185948C9")) {
                            Content = "Answer 3",
                            DisplayOrder = 2
                        },
                        new(new Guid("5F490DB3-5632-47F4-B046-91A988BFE2A9")) {
                            Content = "Answer 4",
                            DisplayOrder = 3
                        }
                    }
                },
                new(new Guid("722871E3-DF7F-4E7A-8689-7CFB106D8F72")) {
                    Content = "Question 1",
                    CorrectOptionId = new Guid("42A57A1A-262E-4FF3-9561-F1874D96CD0D"),
                    DisplayOrder = 0,
                    Options = new List<QuizQuestionOption> {
                        new(new Guid("42A57A1A-262E-4FF3-9561-F1874D96CD0D")) {
                            Content = "Answer 1",
                            DisplayOrder = 0
                        },
                        new(new Guid("7468ECAA-973F-4090-8470-7BC27B8D14FE")) {
                            Content = "Answer 2",
                            DisplayOrder = 1
                        }
                    }
                }
            }
        };


    [Fact]
    public void AddAnswer_ForCorrectAnswer_ProcessesCorrectly()
    {
        // Arrange
        var sut = QuizRun.CreateRun(TestUsername, TestQuizDefinition);
        var runQuestion1 = sut.GetQuestionByDefinitionId(TestQuizDefinition.Questions.First().Id);

        // Act
        sut.AddAnswer(runQuestion1.Id, runQuestion1.CorrectOptionId);

        // Assert
        runQuestion1.HasAnswer.ShouldBeTrue();
        runQuestion1.HasCorrectAnswer.ShouldBeTrue();
    }


    [Fact]
    public void AddAnswer_ForIncorrectAnswer_ProcessesCorrectly()
    {
        // Arrange
        var sut = QuizRun.CreateRun(TestUsername, TestQuizDefinition);
        var runQuestion1 = sut.GetQuestionByDefinitionId(TestQuizDefinition.Questions.First().Id);

        // Act
        sut.AddAnswer(runQuestion1.Id, runQuestion1.Options.First().Id);

        // Assert
        runQuestion1.HasAnswer.ShouldBeTrue();
        runQuestion1.HasCorrectAnswer.ShouldBeFalse();
    }


    [Fact]
    public void AddAnswer_ForInvalidOptionId_Throws()
    {
        // Arrange
        var sut = QuizRun.CreateRun(TestUsername, TestQuizDefinition);
        var runQuestion1 = sut.GetQuestionByDefinitionId(TestQuizDefinition.Questions.First().Id);
        var incorrectOptionId = Guid.Empty;

        // Act
        // Asset
        var thrownException = Should.Throw<ApplicationException>(() => sut.AddAnswer(runQuestion1.Id, incorrectOptionId));
        _outputHelper.WriteLine(@$"thrown exception message:
{thrownException.Message}
");
        thrownException.Message.ShouldContain($"option {incorrectOptionId} is not a valid option of question {runQuestion1.Id}");
    }


    [Fact]
    public void AddAnswer_ForInvalidQuestionId_Throws()
    {
        // Arrange
        var sut = QuizRun.CreateRun(TestUsername, TestQuizDefinition);
        var incorrectQuestionId = Guid.Empty;

        // Act
        // Asset
        var thrownException = Should.Throw<ApplicationException>(() => sut.AddAnswer(incorrectQuestionId, Guid.Empty));
        _outputHelper.WriteLine(@$"thrown exception message:
{thrownException.Message}
");
        thrownException.Message.ShouldContain($"quiz run question {incorrectQuestionId} not found");
    }


    [Fact]
    public void AddAnswer_WhenAnsweringAllQuestions_ProcessesQuizRunCorrectly()
    {
        // Arrange
        var sut = QuizRun.CreateRun(TestUsername, TestQuizDefinition);

        // Act
        foreach (var quizRunQuestion in sut.Questions)
        {
            sut.AddAnswer(quizRunQuestion.Id, quizRunQuestion.CorrectOptionId);
        }

        // Assert
        _outputHelper.WriteLine(@$"
{nameof(sut.ProgressPercent)} is {sut.ProgressPercent}
{nameof(sut.AnsweredQuestionsCount)} is {sut.AnsweredQuestionsCount}
{nameof(sut.QuestionCount)} is {sut.QuestionCount}
");

        sut.AllQuestionsAnsweredCorrectly.ShouldBeTrue();
        sut.ProgressPercent.ShouldBe<uint>(100);
    }


    [Fact]
    public void CreateRun_ForValidDefinition_ReturnsCorrectRun()
    {
        // Arrange
        var sut = QuizRun.CreateRun(TestUsername, TestQuizDefinition);

        // Act

        // Assert
        sut.Username.ShouldBe(TestUsername);
        sut.QuizDefinitionId.ShouldBe(TestQuizDefinition.Id);
        sut.QuestionCount.ShouldBe(TestQuizDefinition.QuestionCount);

        foreach (var quizRunQuestion in sut.Questions)
        {
            var definitionQuestion = TestQuizDefinition.GetQuestion(quizRunQuestion.QuestionDefinitionId);
            definitionQuestion.ShouldNotBeNull();
            quizRunQuestion.OptionCount.ShouldBe(definitionQuestion.OptionCount);
        }
    }


    [Fact]
    public void GetNextQuestion_ForCompleteQuizRun_ReturnsNull()
    {
        // Arrange
        var sut = QuizRun.CreateRun(TestUsername, TestQuizDefinition);
        var runQuestion1 = sut.GetQuestionByDefinitionId(TestQuizDefinition.Questions.ElementAt(0).Id);
        var runQuestion2 = sut.GetQuestionByDefinitionId(TestQuizDefinition.Questions.ElementAt(1).Id);
        sut.AddAnswer(runQuestion1.Id, runQuestion1.CorrectOptionId);
        sut.AddAnswer(runQuestion2.Id, runQuestion2.CorrectOptionId);

        // Act
        var (nextQuestion, nextQuestionIndex) = sut.GetNextQuestion();

        // Assert
        nextQuestion.ShouldBeNull();
        nextQuestionIndex.ShouldBeNull();
    }
}
