using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VideoClipComposer.Infrastructure.Data
{
    public class VideoProjectsDbContext : DbContext
    {
        public VideoProjectsDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
