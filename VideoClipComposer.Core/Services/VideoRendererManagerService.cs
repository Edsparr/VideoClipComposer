using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VideoClipComposer.Abstractions.Services;

namespace VideoClipComposer.Core.Services
{
    public sealed class VideoRendererManagerHostedService : IHostedService
    {
        private readonly IServiceScopeFactory scopeFactory;

        public VideoRendererManagerHostedService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        private Tuple<CancellationTokenSource, Task> tokenSource;

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            if (tokenSource != null)
                await StopAsync(cancellationToken);

            var source = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            var task = Run(cancellationToken);

            tokenSource = new Tuple<CancellationTokenSource, Task>(source, task);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            if (tokenSource == null)
                return;

            tokenSource.Item1.Cancel();
            await Task.WhenAny(tokenSource.Item2, Task.Delay(-1, cancellationToken));

            if (!tokenSource.Item2.IsCompleted)
                cancellationToken.ThrowIfCancellationRequested(); //Means StopAsync got cancelled.
        }

        private async Task Run(CancellationToken cancellationToken)
        {
            using(var scope = scopeFactory.CreateScope())
            {
                while (true)
                {
                    var videoRenderer = scope.ServiceProvider.GetRequiredService<IVideoRendererService>(); //To make lifetime more mangable.
                    await videoRenderer.RenderAsync(cancellationToken);
                    //Publish etc.

                    if (cancellationToken.IsCancellationRequested)
                        break; //We do not want to cancel while in a rendering session

                }
            }
        }
    }
}
