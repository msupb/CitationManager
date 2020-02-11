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
        ICommandFactory commandFactory;     

        public frmCitationForm(CitationDetailsObject citationDetails, ICitationFactory citationFactory, ICommandFactory commandFactory)
        {
            this.citationFactory = citationFactory;
            this.citationDetails = citationDetails;
            this.commandFactory = commandFactory;

            InitializeComponent();
            LoadContent();
        }

        #region Private methods

        private void LoadContent()
        {
            lstCitations.Items.Clear();
            IEnumerable<CitationModel> citationList = commandFactory.Execute();

            foreach (CitationModel item in citationList)
            {
                ListViewItem listItem = new ListViewItem(item.CitationString);
                listItem.Tag = item.Id;
                lstCitations.Items.Add(listItem);
            }                  
        }

        private void DeleteCitation()
        {
            lstCitations.LabelEdit = true;
            commandFactory.Execute((int)lstCitations.Items[lstCitations.SelectedIndices[0]].Tag);
            lstCitations.Items.RemoveAt(lstCitations.SelectedIndices[0]);
        }

        #endregion

        #region Event handlers

        private void ListViewClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(lstCitations.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenu.Show(Cursor.Position);
                }
            }
        }

        private void ContextMenuDeleteAction(object sender, EventArgs e)
        {
            DeleteCitation();
        }

        private void AddCitationForm(object sender, EventArgs e)
        {
            ManageCitationForm manageCitationForm = new ManageCitationForm(commandFactory, citationDetails, citationFactory);
            manageCitationForm.FormClosing += new FormClosingEventHandler(this.AddCitationFormClosing);
            manageCitationForm.Show();
        }

        private void AddCitationFormClosing(object sender, FormClosingEventArgs e)
        {
            LoadContent();
        }

        #endregion
    }
}
