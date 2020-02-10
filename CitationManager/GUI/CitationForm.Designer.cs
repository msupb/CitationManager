namespace GUI
{
    partial class frmCitationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstCitations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddCitation = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCitations
            // 
            this.lstCitations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstCitations.HideSelection = false;
            this.lstCitations.Location = new System.Drawing.Point(93, 12);
            this.lstCitations.Name = "lstCitations";
            this.lstCitations.Size = new System.Drawing.Size(722, 526);
            this.lstCitations.TabIndex = 18;
            this.lstCitations.UseCompatibleStateImageBehavior = false;
            this.lstCitations.View = System.Windows.Forms.View.Details;
            this.lstCitations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Citation";
            this.columnHeader1.Width = 500;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuDeleteAction);
            // 
            // btAddCitation
            // 
            this.btAddCitation.Location = new System.Drawing.Point(12, 12);
            this.btAddCitation.Name = "btAddCitation";
            this.btAddCitation.Size = new System.Drawing.Size(75, 23);
            this.btAddCitation.TabIndex = 19;
            this.btAddCitation.Text = "Add Citation";
            this.btAddCitation.UseVisualStyleBackColor = true;
            this.btAddCitation.Click += new System.EventHandler(this.AddCitationForm);
            // 
            // frmCitationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 552);
            this.Controls.Add(this.btAddCitation);
            this.Controls.Add(this.lstCitations);
            this.Name = "frmCitationForm";
            this.Text = "Citation manager";
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstCitations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btAddCitation;
    }
}