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
        ICommand command;     

        public frmCitationForm(IObjectRepository<CitationModel> repository, ICitationModelMapper mapper, CitationDetailsObject citationDetails, ICitationFactory citationFactory, ICommand command)
        {
            this.citationFactory = citationFactory;
            this.citationDetails = citationDetails;
            this.repository = repository;
            this.mapper = mapper;
            this.command = command;

            InitializeComponent();
            cbStyle.DataSource = Enum.GetValues(typeof(CitationStyle));
            cbType.DataSource = Enum.GetValues(typeof(CitationType));
            LoadContent();
        }

        private void LoadContent()
        {
            GetCitationsCommand getCitations = new GetCitationsCommand(repository as CitationObjectRepository<CitationModel>);
            IEnumerable<CitationModel> citationList = getCitations.GetCitations();
            citationList.ToList();

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

            Citation c = citationFactory.CreateCitation(citationDetails);
            (command as AddCitationCommand).Add(c);

            LoadContent();
        }

        private void Generate(object sender, EventArgs e)
        {
            UpdateContent();
        }
    }
}
