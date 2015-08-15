using System.IO;

namespace DejaTunes.Core.Entities
{
    public class FileWrapper
    {
        private readonly FileInfo fileInfo;

        public FileWrapper(FileInfo fileInfo)
        {
            this.fileInfo = fileInfo;
        }

        public FileInfo FileInfo { get { return this.fileInfo; } }
    }
}