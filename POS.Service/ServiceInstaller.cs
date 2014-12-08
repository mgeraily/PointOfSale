using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace POS.Service
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                      AllTypes.FromThisAssembly().InNamespace("POS.Service")
                     .WithService.DefaultInterfaces()
                     .Configure(c => c.LifestyleTransient()));
        }
    }
}
