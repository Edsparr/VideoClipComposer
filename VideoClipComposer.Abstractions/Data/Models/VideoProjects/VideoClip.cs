using System;
using System.Collections.Generic;
using System.Text;

namespace VideoClipComposer.Abstractions.Data.Models.VideoProjects
{
    public class VideoClip
    {
        public int ProjectId { get; set; }
        public virtual VideoProject Project { get; set; }

        public string ClipLink { get; set; }

    }
}
