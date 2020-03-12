using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClipComposer.Abstractions.Data.Models;
using VideoClipComposer.Abstractions.Data.Models.VideoProjects;
using VideoClipComposer.Abstractions.Data.Repositories;
using VideoClipComposer.Abstractions.Data.Repositories.VideoProjects;

namespace VideoClipComposer.Infrastructure.Data.Repositories.VideoProjects
{
    public sealed class VideoClipRepository : VideoProjectsDataRepository<VideoClip>, IVideoClipRepository
    {
        public VideoClipRepository(VideoProjectsDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<VideoClip>> GetAllClips(int projectId)
        {
            return await dbContext.Set<VideoClip>()
                .Where(c => c.ProjectId == projectId)
                .ToArrayAsync();
        }
    }
}
