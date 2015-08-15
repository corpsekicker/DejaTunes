using System.Collections.Generic;
using System.IO;

namespace DejaTunes.Core.Services
{
    public interface IFileManagementService
    {
        List<FileInfo> CollectFiles(string parentLocation, bool searchRecursively, string searchPattern);

        List<FileInfo> FindDuplicates(List<FileInfo> files, DuplicateSearchMethod duplicateSearchMethod);
    }
}