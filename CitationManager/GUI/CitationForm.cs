using Data.Commands;
using Data.Models;
using Reference.Builder.Core;
using Reference.Builder.Core.Citations;
using Reference.Builder.Core.Exporters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCitationForm : Form
    {
        readonly CitationDetailsObject citationDetails;
        readonly ICitationFactory citationFactory;
        readonly ICommandFactory commandFactory;
        readonly IExporter xlsExporter;

        public frmCitationForm(CitationDetailsObject citationDetails, ICitationFactory citationFactory, ICommandFactory commandFactory, IExporter xlsExporter)
        {
            this.citationFactory = citationFactory;
            this.citationDetails = citationDetails;
            this.commandFactory = commandFactory;
            this.xlsExporter = xlsExporter;

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
                ListViewItem listItem = new ListViewItem(item.CitationString)
                {
                    Tag = item.Id
                };
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

        private void Export(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook| * .xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    
                    if (xlsExporter.Export(lstCitations, sfd.FileName))
                        MessageBox.Show("Citation list successfully exported.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something went wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }

        #endregion
    }
}
