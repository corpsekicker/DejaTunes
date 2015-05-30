using System.Collections.Generic;

namespace DejaTunes.Core.Services
{
    public interface IFileManagementService
    {
        List<File> CollectFiles(string parentLocation, bool searchRecursively);
    }
}