using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DejaTunes.Core.Services
{
    public class FileManagementService : IFileManagementService
    {
        public List<FileInfo> CollectFiles(string parentLocation, bool searchRecursively)
        {
            var filePaths = Directory.GetFiles(parentLocation);
            var fileInfos = filePaths.Select(filePath => new FileInfo(filePath)).ToList();

            if (searchRecursively)
            {
                string[] directories = Directory.GetDirectories(parentLocation);
                foreach (string directory in directories)
                {
                    fileInfos.AddRange(this.CollectFiles(directory, true));
                }
            }

            return fileInfos;
        }

        public List<FileInfo> FindDuplicates(List<FileInfo> files, bool byFileSize)
        {
            List<FileInfo> duplicatedByName = files.Where(x => files.Any(y => x != y && x.Name == y.Name)).ToList();
            return duplicatedByName;
            //TODO: By file
        }
    }
}