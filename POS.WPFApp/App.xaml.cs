using System.Windows;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using GalaSoft.MvvmLight.Threading;

namespace POS.WPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        static App()
        {
            DispatcherHelper.Initialize();


            var container = new WindsorContainer();
            container.Install(FromAssembly.InDirectory());
        }


        
        
            
        
    }
}
