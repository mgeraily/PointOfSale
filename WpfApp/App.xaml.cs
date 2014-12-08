using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using POS.Repository;
using POS.Service;
using POS.Service.Dto;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IWindsorContainer _container;
      protected override void OnStartup(StartupEventArgs e)
      {
          base.OnStartup(e);
          ContainerInstaller();
          AutoMapperInit();
      }


        private void ContainerInstaller()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());


            
            _container.Install(
                new ServiceInstaller(),
                new RepositoryInstaller() 
                // and all your other installers
                );


            //_container.Install(
            //    FromAssembly.This(),
            //    FromAssembly.Named("Acme.Crm.Bootstrap"),
            //    FromAssembly.Containing<ServicesInstaller>(),
            //    FromAssembly.InDirectory(new AssemblyFilter("Extensions")),
            //    FromAssembly.Instance(this.GetPluginAssembly()));



            //_container.Install(
            //    new ControllersInstaller(),
            //    new RepositoriesInstaller(), 
            //    // and all your other installers
            //    );
        }

        private static void AutoMapperInit()
        {
            AutoMapper.Mapper.Initialize(a =>
            {
                a.AddProfile<MappingProfile>();
                
            });
        }

    }
}
