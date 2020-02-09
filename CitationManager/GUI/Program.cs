using Castle.Windsor;
using Data.Commands;
using Data.Context;
using Data.Models;
using Data.Repository;
using Reference.Builder.Core;
using Reference.Builder.Core.Citations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WindsorContainer container = new WindsorContainer();
            container.Install(new Installer());
            ICitationFactory citationFactory = container.Resolve<ICitationFactory>();
            ICitationModelMapper mapper = container.Resolve<ICitationModelMapper>();
            IObjectRepository<CitationModel> repository = container.Resolve<IObjectRepository<CitationModel>>();
            ICommand command = container.Resolve<ICommand>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCitationForm(repository, mapper, new CitationDetailsObject(), citationFactory, command));
        }
    }
}
