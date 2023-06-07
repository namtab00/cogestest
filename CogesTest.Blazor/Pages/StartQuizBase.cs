using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CogesTest.Blazor.Infrastructure;
using CogesTest.Blazor.Services;
using CogesTest.Domain.Entities;
using CogesTest.Domain.Services;
using Microsoft.AspNetCore.Components;

namespace CogesTest.Blazor.Pages;

public class StartQuizBase : CogesTestComponentBase
{
    public const string RouteName = "StartQuiz";

    protected List<QuizDefinition> AvailableQuizzes { get; set; } = new();

    protected bool CanStart {
        get {
            var userNameIsSet = !string.IsNullOrWhiteSpace(UserName?.Trim());

            return !Loading && QuizSelected && userNameIsSet;
        }
    }

    [Parameter]
    public string CurrentUsername { get; set; }

    [Inject]
    protected NavigationManager NavigationService { get; set; }

    [Inject]
    protected IQuizDefinitionService QuizDefinitionService { get; set; }

    protected bool QuizSelected => SelectedQuizId != default;

    [Inject]
    protected IQuizRunService RunService { get; set; }

    public string SelectedQuizDescription {
        get {
            if (!QuizSelected)
            {
                return null;
            }

            var selectedQuizDefinition = AvailableQuizzes.FirstOrDefault(q => q.Id == SelectedQuizId);

            return selectedQuizDefinition?.Description;
        }
    }

    protected Guid SelectedQuizId { get; set; } = default;

    [Inject]
    public TitleService TitleService { get; set; }

    protected string UserName { get; set; } = string.Empty;


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            await TitleService.SetTitleAsync("Take a quiz");
        }

        await base.OnAfterRenderAsync(firstRender);
    }


    protected override async Task OnInitializedAsync()
    {
        AvailableQuizzes = await QuizDefinitionService.FetchAllDefinitionsAsync(CancellationToken);
        if (!string.IsNullOrWhiteSpace(CurrentUsername))
        {
            UserName = WebUtility.UrlDecode(CurrentUsername);
        }

        Loading = false;
    }


    protected async Task StartQuizAsync()
    {
        if (!CanStart)
        {
            throw new ApplicationException($"cannot start quiz");
        }

        if (Loading)
        {
            return;
        }

        UserName = UserName.Trim();


        Loading = true;

        var createdRun = await RunService.CreateAsync(UserName, SelectedQuizId, CancellationToken)
                         ?? throw new ApplicationException($"could not start quiz {SelectedQuizId}");

        Loading = false;

        StateHasChanged();

        NavigationService.NavigateTo($"/{TakeQuizBase.RouteName}/{createdRun.Id}");
    }
}
