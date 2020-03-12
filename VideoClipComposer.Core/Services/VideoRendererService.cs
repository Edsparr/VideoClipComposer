using System.Threading;
using System.Threading.Tasks;
using VideoClipComposer.Abstractions.Data.Models;
using VideoClipComposer.Abstractions.Data.Models.VideoProjects;
using VideoClipComposer.Abstractions.Data.Repositories;
using VideoClipComposer.Abstractions.Data.Repositories.VideoProjects;
using VideoClipComposer.Abstractions.Services;

namespace VideoClipComposer.Core.Services
{
    public class VideoRendererService : IVideoRendererService
    {
        private readonly IDataRepository<VideoProject> videoProjectRepository;
        private readonly IVideoClipRepository videoClipRepository;

        public VideoRendererService(IDataRepository<VideoProject> videoProjectRepository, IVideoClipRepository videoClipRepository)
        {
            this.videoProjectRepository = videoProjectRepository;
            this.videoClipRepository = videoClipRepository;
        }

        public async Task RenderAsync(CancellationToken cancellationToken = default)
        {
            var project = await videoProjectRepository.FindFirstAsync();
            var clips = await videoClipRepository.GetAllClips(project.ProjectId);

            foreach(var clip in clips)
            {

            }
        }
    }
}