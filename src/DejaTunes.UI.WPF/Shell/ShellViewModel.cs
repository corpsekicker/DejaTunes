namespace DejaTunes.UI.WPF.Shell
{
    public class ShellViewModel : IShellViewModel
    {
        private IShellModel model;

        public IShellModel Model
        {
            get { return model; }
            set { model = value; }
        }

        public IShellModel GetModel()
        {
            return this.Model;
        }

        public ShellViewModel()
        {
            this.model = new ShellModel
            {
                Caption = "Test Caption"
            };
        }
    }
}