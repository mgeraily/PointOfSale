using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using POS.Repository.Context;

namespace POS.Repository
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                      AllTypes.FromThisAssembly().InNamespace("POS.Repository")
                     .WithService.DefaultInterfaces()
                     .Configure(c => c.LifestyleTransient()));

            container.Register(Component.For<IUnitOfWork>().ImplementedBy<EfContext>().LifestyleSingleton());

        }
    }
}
