namespace DejaTunes.UI.WPF.Shell
{
    public interface IShellViewModel
    {
        IShellModel Model { get; set; }

        IShellModel GetModel();
    }
}