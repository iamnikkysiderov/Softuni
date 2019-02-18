using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo : Stream
    {
        private File file;
        
        public StreamProgressInfo(File file)
        {
            this.file = file;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }

        public int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}
