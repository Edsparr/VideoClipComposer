using System;
using System.Collections.Generic;
using System.Text;

namespace VideoClipComposer.Abstractions.Data.Models.VideoProjects
{
    public class VideoProject
    {
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public virtual ICollection<VideoClip> Clips { get; set; }

    }
}
