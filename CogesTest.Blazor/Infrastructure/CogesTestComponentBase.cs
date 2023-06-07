using System;
using System.Threading;
using Microsoft.AspNetCore.Components;

namespace CogesTest.Blazor.Infrastructure;

public abstract class CogesTestComponentBase : ComponentBase, IDisposable
{
    private CancellationTokenSource _cancellationTokenSource;

    protected CancellationToken CancellationToken => (_cancellationTokenSource ??= new CancellationTokenSource()).Token;

    protected bool Loading { get; set; } = true;


    public virtual void Dispose()
    {
        if (_cancellationTokenSource == null)
        {
            return;
        }

        _cancellationTokenSource.Cancel();
        _cancellationTokenSource.Dispose();
        _cancellationTokenSource = null;
    }
}
