using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Data.Commands;
using Data.Context;
using Data.Models;
using Data.Repository;
using Reference.Builder.Core.Citations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ICitationFactory>().ImplementedBy<CitationFactory>());
            container.Register(Component.For<ICitationModelMapper>().ImplementedBy<CitationModelMapper>());

            container.Register(Component.For<IObjectRepository<CitationModel>>().ImplementedBy<CitationObjectRepository<CitationModel>>()
                .DependsOn(Property.ForKey<CitationContext>().Eq(new CitationContext())));

            container.Register(Component.For<ICommand>().ImplementedBy<AddCitationCommand>()
                .DependsOn(Property.ForKey<ICitationModelMapper>().Eq(container.Resolve<ICitationModelMapper>()))
                .DependsOn(Property.ForKey<CitationModel>().Eq(new CitationModel()))
                .DependsOn(Property.ForKey<IObjectRepository<CitationModel>>().Eq(container.Resolve<IObjectRepository<CitationModel>>())));

            container.Register(Component.For<ICommand>().ImplementedBy<GetCitationsCommand>()
                .DependsOn(Property.ForKey<IObjectRepository<CitationModel>>().Eq(container.Resolve<IObjectRepository<CitationModel>>())));
        }
    }
}
