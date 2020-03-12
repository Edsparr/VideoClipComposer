using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VideoClipComposer.Abstractions.Data.Models.VideoProjects;

namespace VideoClipComposer.Infrastructure.Data.Configurations.VideoProjects
{
    public sealed class VideoClipConfiguration : IEntityTypeConfiguration<VideoClip>
    {
        public void Configure(EntityTypeBuilder<VideoClip> builder)
        {
            builder.HasKey(c => new { c.ClipLink, c.ProjectId });
            
            builder.HasOne(c => c.Project)
                .WithMany(c => c.Clips)
                .HasForeignKey(c => new { c.ProjectId });

            builder.Property(c => c.ClipLink)
                .HasMaxLength(500);
        }
    }
}
