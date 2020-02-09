using Data.Commands;
using Data.Models;
using Data.Repository;
using Reference.Builder.Core;
using Reference.Builder.Core.Citations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCitationForm : Form
    {
        CitationDetailsObject citationDetails;
        ICitationFactory citationFactory;
        IObjectRepository<CitationModel> repository;
        ICitationModelMapper mapper;
        ICommandFactory commandFactory;     

        public frmCitationForm(IObjectRepository<CitationModel> repository, ICitationModelMapper mapper, CitationDetailsObject citationDetails, ICitationFactory citationFactory, ICommandFactory commandFactory)
        {
            this.citationFactory = citationFactory;
            this.citationDetails = citationDetails;
            this.repository = repository;
            this.mapper = mapper;
            this.commandFactory = commandFactory;

            InitializeComponent();
            cbStyle.DataSource = Enum.GetValues(typeof(CitationStyle));
            cbType.DataSource = Enum.GetValues(typeof(CitationType));
            LoadContent();
        }

        private void LoadContent()
        {
            IEnumerable<CitationModel> citationList = commandFactory.GetCitations();

            foreach (CitationModel item in citationList)
                lstCitations.Items.Add(item.CitationString);          
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
            commandFactory.Add(citation);

            LoadContent();
        }

        private void Generate(object sender, EventArgs e)
        {
            UpdateContent();
        }
    }
}
