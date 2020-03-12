using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VideoClipComposer.Abstractions.Data.Repositories.VideoProjects;

namespace VideoClipComposer.Infrastructure.Data.Repositories.VideoProjects
{
    public class VideoProjectsDataRepository<TItem> : DataRepositoryBase<TItem>, IVideoProjectsDataRepository<TItem>
        where TItem : class
    {
        public VideoProjectsDataRepository(VideoProjectsDbContext dbContext) : base(dbContext)
        {

        }


    }
}
