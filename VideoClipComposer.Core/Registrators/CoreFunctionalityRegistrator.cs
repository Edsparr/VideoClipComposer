using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VideoClipComposer.Abstractions.Services;
using VideoClipComposer.Core.Services;
using VideoClipComposer.Core.Services.Clips;

namespace VideoClipComposer.Core.Registrators
{
    public static class CoreFunctionalityRegistrator
    {
        public static void AddCoreFunctionality(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddHostedService<VideoRendererManagerHostedService>();
            services.AddScoped<IVideoRendererService, VideoRendererService>();

            AddClipDownloaders(services);
        }

        public static void AddClipDownloaders(this IServiceCollection services)
        {
            services.AddScoped<IClipDownloaderService, TwitchClipDownloaderService>();
        }
    }
}
