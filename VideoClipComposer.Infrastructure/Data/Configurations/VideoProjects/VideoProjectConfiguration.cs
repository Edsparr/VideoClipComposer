using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VideoClipComposer.Abstractions.Data.Models;
using VideoClipComposer.Abstractions.Data.Models.VideoProjects;

namespace VideoClipComposer.Infrastructure.Data.Configurations.VideoProjects
{
    public class VideoProjectConfiguration : IEntityTypeConfiguration<VideoProject>
    {
        public void Configure(EntityTypeBuilder<VideoProject> builder)
        {
            builder.HasKey(c => new { c.ProjectId });

            builder.Property(c => c.ProjectName)
                .HasMaxLength(100);
        }
    }
}
