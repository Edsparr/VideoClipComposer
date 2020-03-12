using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using VideoClipComposer.Abstractions.FFmpeg;

namespace VideoClipComposer.FFmpeg
{
    public class FFmpegEngine : IFFmpegEngine
    {
        private readonly IOptions<FFmpegEngineOptions> engineOptions;
        
        public FFmpegEngine(IOptions<FFmpegEngineOptions> engineOptions)
        {
            this.engineOptions = engineOptions;
        }


    }
}
