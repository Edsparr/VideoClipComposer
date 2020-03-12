using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VideoClipComposer.Abstractions.Clips
{
    public class ClipDownloadResult : IDisposable
    {
        public ClipDownloadResult(Stream downloadStream, string extension)
        {
            this.DownloadStream = downloadStream ?? throw new ArgumentNullException(nameof(downloadStream));
            this.Extension = extension ?? throw new ArgumentNullException(nameof(extension));
        }
        public Stream DownloadStream { get; }
        public string Extension { get; }

        protected virtual void Dispose(bool disposing)
        {
            DownloadStream?.Dispose();  
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
