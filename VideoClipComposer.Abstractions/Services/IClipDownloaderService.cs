using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VideoClipComposer.Abstractions.Clips;

namespace VideoClipComposer.Abstractions.Services
{
    public interface IClipDownloaderService
    {
        string Domain { get; }

        ValueTask<ClipDownloadResult> DownloadAsync(string url);
    }
}
