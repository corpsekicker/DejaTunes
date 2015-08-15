using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DejaTunes.Core.Services
{
    public class FileManagementService : IFileManagementService
    {
        public List<FileInfo> CollectFiles(string parentLocation, bool searchRecursively, string searchPattern)
        {
            if (parentLocation.Contains(@"$"))
            {
                return new List<FileInfo>();
            }

            string[] filePaths;
            List<FileInfo> fileInfos;
            try
            {
                filePaths = string.IsNullOrEmpty(searchPattern) ? Directory.GetFiles(parentLocation) : Directory.GetFiles(parentLocation, searchPattern);
                fileInfos = filePaths.Select(filePath => new FileInfo(filePath)).ToList();
            }
            catch
            {
                return new List<FileInfo>();
            }

            if (searchRecursively)
            {
                string[] directories = Directory.GetDirectories(parentLocation);
                foreach (string directory in directories)
                {
                    fileInfos.AddRange(this.CollectFiles(directory, true, searchPattern));
                }
            }

            return fileInfos;
        }

        public List<FileInfo> FindDuplicates(List<FileInfo> files, DuplicateSearchMethod duplicateSearchMethod)
        {
            List<FileInfo> result = new List<FileInfo>();
            switch (duplicateSearchMethod)
            {
                case DuplicateSearchMethod.ByFileName:
                    var groupedByName = files.GroupBy(x => x.Name);
                    foreach (var grouping in groupedByName)
                    {
                        result.AddRange(grouping.Except(new [] { grouping.First() }));
                    }
                    break;
                case DuplicateSearchMethod.ByFileSize:
                    var groupedBySize = files.GroupBy(x => x.Length);
                    foreach (var grouping in groupedBySize)
                    {
                        result.AddRange(grouping.Except(new[] { grouping.First() }));
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(duplicateSearchMethod), duplicateSearchMethod, null);
            }
            return result;

            List<FileInfo> duplicatedByName = files.Where(x => files.Any(y => x != y && x.Name == y.Name)).ToList();
            return duplicatedByName;
        }
    }
}