using System;
using System.Threading.Tasks;
using CogesTest.Blazor.Infrastructure;
using CogesTest.Blazor.Services;
using CogesTest.Domain.Entities;
using CogesTest.Domain.Services;
using Microsoft.AspNetCore.Components;

namespace CogesTest.Blazor.Pages;

public class TakeQuizBase : CogesTestComponentBase
{
    public const string RouteName = "Quiz";

    protected bool CanProceed {
        get {
            return !Loading && OptionSelected;
        }
    }

    protected QuizRunQuestion CurrentQuestion { get; set; } = new();

    protected uint? CurrentQuestionIndex { get; set; }

    protected bool IsLastQuestion => QuizRun?.IsLastQuestion(CurrentQuestion) ?? false;

    [Inject]
    protected NavigationManager NavigationService { get; set; }

    protected bool OptionSelected => SelectedOptionId != default;

    protected QuizRun QuizRun { get; set; }

    public Guid QuizRunId => Guid.Parse(QuizRunIdParam);

    [Parameter]
    public string QuizRunIdParam { get; set; }

    [Inject]
    protected IQuizRunService RunService { get; set; }

    protected Guid SelectedOptionId { get; set; }

    [Inject]
    public TitleService TitleService { get; set; }


    protected async Task AnswerAndProceedAsync()
    {
        if (!CanProceed) { return; }

        Loading = true;

        QuizRun = await RunService.AddAnswerAsync(QuizRunId, CurrentQuestion.Id, SelectedOptionId, CancellationToken);
        SelectedOptionId = default;
        (CurrentQuestion, CurrentQuestionIndex) = QuizRun.GetNextQuestion();

        if (CurrentQuestion == null)
        {
            NavigationService.NavigateTo($"/{QuizResultBase.RouteName}/{QuizRun.Id}");
        }
        else
        {
            StateHasChanged();
            Loading = false;
        }
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            await TitleService.SetTitleAsync($"Quiz {QuizRun.Title} {QuizRun.ProgressPercent}%");
        }

        await base.OnAfterRenderAsync(firstRender);
    }


    protected override async Task OnParametersSetAsync()
    {
        Loading = true;
        QuizRun = await RunService.GetRunAsync(QuizRunId, CancellationToken);
        Loading = false;

        (CurrentQuestion, CurrentQuestionIndex) = QuizRun.GetNextQuestion();
    }


    protected void ToggleSelection(Guid optionId)
    {
        if (!OptionSelected)
        {
            SelectedOptionId = optionId;
            return;
        }

        if (SelectedOptionId == optionId)
        {
            SelectedOptionId = default;
            return;
        }

        SelectedOptionId = optionId;
        StateHasChanged();
    }
}
