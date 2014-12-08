using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;

namespace WpfApp
{
    public class WpfAppInstallers : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container,
            Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {




            //container.Install(
            //    new ControllersInstaller(),
            //    new RepositoriesInstaller(), 
            //    // and all your other installers
            //    );


            //container.Install(
            //    FromAssembly.This(),
            //    FromAssembly.Named("Acme.Crm.Bootstrap"),
            //    FromAssembly.Containing<ServicesInstaller>(),
            //    FromAssembly.InDirectory(new AssemblyFilter("Extensions")),
            //    FromAssembly.Instance(this.GetPluginAssembly()));
            
        }

    }

}
