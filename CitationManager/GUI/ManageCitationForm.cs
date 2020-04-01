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
        #region Properties

        private readonly ICommandFactory commandFactory;
        private readonly CitationDetailsObject citationDetails;
        private readonly ICitationFactory citationFactory;
        private readonly List<Author> authors = new List<Author>();

        #endregion

        #region Constructor
        public ManageCitationForm(ICommandFactory commandFactory, CitationDetailsObject citationDetails, ICitationFactory citationFactory)
        {
            this.commandFactory = commandFactory;
            this.citationDetails = citationDetails;
            this.citationFactory = citationFactory;

            InitializeComponent();
            cbStyle.DataSource = Enum.GetValues(typeof(CitationStyle));
            cbType.DataSource = Enum.GetValues(typeof(CitationType));
            SetUiByType(CitationType.Book);
            AddAuthorControls();
        }

        #endregion

        #region private methods
        private void UpdateContent()
        {
            CitationStyle style = (CitationStyle)cbStyle.SelectedItem;
            CitationType type = (CitationType)cbType.SelectedItem;
            
            citationDetails.title = tbTitle.Text;
            citationDetails.authors = GetAuthors();
            citationDetails.year = tbYear.Text;

            if(type == CitationType.Book)
                citationDetails.publisher = new Publisher(tbPublisher.Text);

            if(type == CitationType.Article)
            {
                citationDetails.journal = new Journal(tbJournal.Text);
                citationDetails.doi = tbDoi.Text;
            }

            citationDetails.style = style;
            citationDetails.type = type;

            Citation citation = citationFactory.CreateCitation(citationDetails);
            commandFactory.Execute(citation);

            Close();
        }

        private void SetUiByType(CitationType type)
        {
            List<Control> bookControls = new List<Control>() { tbPublisher, lblPublisher };
            List<Control> articleControls = new List<Control>() { tbJournal, lblJournal, tbDoi, lblDoi };

            if (type == CitationType.Book)
            {
                bookControls.ForEach(x => x.Show());
                articleControls.ForEach(x => x.Hide());
            }
            else if (type == CitationType.Article)
            {
                articleControls.ForEach(x => x.Show());
                bookControls.ForEach(x => x.Hide());              
            }
            else if (type == CitationType.Webpage)
            {
                // TODO fix these controls
            }
        }

        private void AddAuthorControls()
        {
            TextBox textboxFirstName = new TextBox();
            int countFirst = pnFirstName.Controls.OfType<TextBox>().ToList().Count;
            textboxFirstName.Location = new System.Drawing.Point(3, 25 * countFirst);
            textboxFirstName.Size = new System.Drawing.Size(100, 20);
            textboxFirstName.Name = "tbFristName" + (countFirst + 1);
            pnFirstName.Controls.Add(textboxFirstName);

            TextBox textboxLastName = new TextBox();
            int countLast = pnLastName.Controls.OfType<TextBox>().ToList().Count;
            textboxLastName.Location = new System.Drawing.Point(3, 25 * countLast);
            textboxLastName.Size = new System.Drawing.Size(100, 20);
            textboxLastName.Name = "tbLastName" + (countLast + 1);
            pnLastName.Controls.Add(textboxLastName);
        }

        private List<Author> GetAuthors()
        {
            List<string> firstNames = new List<string>();
            List<string> lastNames = new List<string>();

            pnFirstName.Controls.OfType<TextBox>().ToList().ForEach(x => firstNames.Add(x.Text));
            pnLastName.Controls.OfType<TextBox>().ToList().ForEach(x => lastNames.Add(x.Text));

            for (int i = 0; i < firstNames.Count; i++)
            {
                authors.Add(new Author(firstNames[i], lastNames[i]));
            }

            return authors;
        }

        #endregion

        #region Event handlers

        private void Generate(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            SetUiByType((CitationType)cbType.SelectedItem);
        }

        #endregion

        private void btAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorControls();
        }
    }
}
