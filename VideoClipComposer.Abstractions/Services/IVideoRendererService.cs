using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VideoClipComposer.Abstractions.Services
{
    public interface IVideoRendererService
    {
        Task RenderAsync(CancellationToken cancellationToken = default);
    }
}
