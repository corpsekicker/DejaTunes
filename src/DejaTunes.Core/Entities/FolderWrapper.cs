using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DejaTunes.Core.Entities
{
    public class FolderWrapper
    {
        private readonly string location;

        public FolderWrapper(string location)
        {
            this.location = location;
        }

        public string Location
        {
            get
            {
                return this.location;
            }
        }

        public List<FileWrapper> GetFiles()
        {
            var files = Directory.GetFiles(this.location).Select(x => new FileWrapper(new FileInfo(x))).ToList();
            return files;
        }
    }
}