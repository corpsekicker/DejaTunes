using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DejaTunes.UI.WPF.Shell;

namespace DejaTunes.UI.WPF
{
    public class Installers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
                //.Register(Component.For<IShellModel>().ImplementedBy<ShellModel>().LifestyleTransient())
                .Register(Component.For<IShellViewModel>().ImplementedBy<ShellViewModel>().LifestyleTransient())
                .Register(Component.For<IShellView>().ImplementedBy<ShellView>().LifestyleTransient())
                .Register(Component.For<MainWindow>().LifestyleTransient());
        }
    }
}