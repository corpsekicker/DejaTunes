using System.ComponentModel;

namespace DejaTunes.Core.Services
{
    public enum DuplicateSearchMethod
    {
        [Description("By File Name")]
        ByFileName,
        [Description("By File Size")]
        ByFileSize,
    }
}