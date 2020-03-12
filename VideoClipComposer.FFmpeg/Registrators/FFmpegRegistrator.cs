using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VideoClipComposer.Abstractions.FFmpeg;

namespace VideoClipComposer.FFmpeg.Registrators
{
    public static class FFmpegRegistrator
    {
        public static void AddFFmpeg(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<FFmpegEngineOptions>(configuration.GetSection("FFmpeg"));
            services.AddScoped<IFFmpegEngine, FFmpegEngine>();
        }
    }
}
