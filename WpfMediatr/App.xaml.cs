using WpfMediatr.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using MediatR;
using Prism.DryIoc;
using DryIoc;
using WpfMediatr.Dependencies;
using IDataObject = WpfMediatr.Dependencies.IDataObject;
using DataObject = WpfMediatr.Dependencies.DataObject;

namespace WpfMediatr
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var container = containerRegistry.GetContainer();
            container.RegisterDelegate<ServiceFactory>(r => r.Resolve);
            //container.RegisterMany(new[] { typeof(IMediator).GetAssembly(), typeof(WpfMediatr).GetAssembly() }, Registrator.Interfaces);

            container.Register<IString, GetString>();
            container.Register<IDateTime, Date>();
            container.Register<IDataObject, DataObject>();

        }
    }
}
