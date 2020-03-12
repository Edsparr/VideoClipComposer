using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VideoClipComposer.Abstractions.Data.Models.VideoProjects;

namespace VideoClipComposer.Abstractions.Data.Repositories.VideoProjects
{
    public interface IVideoClipRepository : IVideoProjectsDataRepository<VideoClip>
    {
        Task<IEnumerable<VideoClip>> GetAllClips(int projectId);
    }
}
