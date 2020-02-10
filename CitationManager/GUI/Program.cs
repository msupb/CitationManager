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
            ICommandFactory commandFactory = container.Resolve<ICommandFactory>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCitationForm(new CitationDetailsObject(), citationFactory, commandFactory));
        }
    }
}
