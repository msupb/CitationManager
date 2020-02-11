using Data.Commands;
using Reference.Builder.Core;
using Reference.Builder.Core.Citations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ManageCitationForm : Form
    {
        ICommandFactory commandFactory;
        CitationDetailsObject citationDetails;
        ICitationFactory citationFactory;

        public ManageCitationForm(ICommandFactory commandFactory, CitationDetailsObject citationDetails, ICitationFactory citationFactory)
        {
            this.commandFactory = commandFactory;
            this.citationDetails = citationDetails;
            this.citationFactory = citationFactory;

            InitializeComponent();
            cbStyle.DataSource = Enum.GetValues(typeof(CitationStyle));
            cbType.DataSource = Enum.GetValues(typeof(CitationType));
        }
        private void UpdateContent()
        {
            CitationStyle style = (CitationStyle)cbStyle.SelectedItem;
            CitationType type = (CitationType)cbType.SelectedItem;
            List<Author> authors = new List<Author>();
            authors.Add(new Author(tbFirstName.Text, tbLastName.Text));
            citationDetails.title = tbTitle.Text;
            citationDetails.authors = authors;
            citationDetails.year = tbYear.Text;
            citationDetails.publisher = new Publisher(tbPublisher.Text);
            citationDetails.style = style;
            citationDetails.type = type;

            Citation citation = citationFactory.CreateCitation(citationDetails);
            commandFactory.Execute(citation);

            this.Close();
            //LoadContent();
        }

        private void Generate(object sender, EventArgs e)
        {
            UpdateContent();
        }
    }
}
