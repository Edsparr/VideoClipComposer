using System;
using System.Collections.Generic;
using System.Text;

namespace VideoClipComposer.Abstractions.Data.Repositories.VideoProjects
{
    public interface IVideoProjectsDataRepository<TItem> : IDataRepository<TItem>
        where TItem : class
    {

    }
}
