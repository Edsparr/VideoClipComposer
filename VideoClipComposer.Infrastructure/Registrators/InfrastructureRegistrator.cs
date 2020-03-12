using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using VideoClipComposer.Abstractions.Data.Repositories;
using VideoClipComposer.Abstractions.Data.Repositories.VideoProjects;
using VideoClipComposer.Infrastructure.Data;
using VideoClipComposer.Infrastructure.Data.Repositories;
using VideoClipComposer.Infrastructure.Data.Repositories.VideoProjects;

namespace VideoClipComposer.Infrastructure.Registrators
{
    public static class InfrastructureRegistrator
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);

            services.AddScoped(typeof(IVideoProjectsDataRepository<>), typeof(VideoProjectsDataRepository<>));
            services.AddScoped<IVideoClipRepository, VideoClipRepository>();
        }

        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VideoProjectsDbContext>(builder =>
            {
                
            });
        }
    }
}
