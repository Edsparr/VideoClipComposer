using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VideoClipComposer.Abstractions.Clips;
using VideoClipComposer.Abstractions.Services;

namespace VideoClipComposer.Core.Services.Clips
{
    public class TwitchClipDownloaderService : IClipDownloaderService
    {
        public string Domain => "twitch.com";


        public ValueTask<ClipDownloadResult> DownloadAsync(string url)
        {
            throw new NotImplementedException();
        }
    }
}
