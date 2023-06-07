using System;
using System.Net;
using System.Threading.Tasks;
using CogesTest.Blazor.Infrastructure;
using CogesTest.Blazor.Services;
using CogesTest.Domain.Entities;
using CogesTest.Domain.Services;
using Microsoft.AspNetCore.Components;

namespace CogesTest.Blazor.Pages;

public class QuizResultBase : CogesTestComponentBase
{
    public const string RouteName = "Result";

    [Inject]
    protected NavigationManager NavigationService { get; set; }

    protected QuizRun QuizRun { get; set; }

    public Guid QuizRunId => Guid.Parse(QuizRunIdParam);

    [Parameter]
    public string QuizRunIdParam { get; set; }

    [Inject]
    protected IQuizRunService RunService { get; set; }

    [Inject]
    public TitleService TitleService { get; set; }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            await TitleService.SetTitleAsync($"Quiz {QuizRun.Title} results");
        }

        await base.OnAfterRenderAsync(firstRender);
    }


    protected override async Task OnParametersSetAsync()
    {
        Loading = true;
        QuizRun = await RunService.GetRunAsync(QuizRunId, CancellationToken);
        Loading = false;
    }


    protected void StartAnother()
    {
        NavigationService.NavigateTo($"/{StartQuizBase.RouteName}/{WebUtility.UrlEncode(QuizRun.Username)}");
    }
}
