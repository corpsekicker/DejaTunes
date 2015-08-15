using System.Collections.Generic;
using System.IO;

namespace DejaTunes.Core.Services
{
    public interface IFileManagementService
    {
        List<FileInfo> CollectFiles(string parentLocation, bool searchRecursively);

        List<FileInfo> FindDuplicates(List<FileInfo> files, bool byFileSize);
    }
}