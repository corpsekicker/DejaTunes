namespace DejaTunes.UI.WPF.Shell
{
    public class ShellView : IShellView
    {
        //public ShellView(MainWindow window)
        //{
        //    Window = window;
        //}

        public MainWindow Window { get; set; }
        public void Run()
        {
            this.Window.Show();
        }
    }
}