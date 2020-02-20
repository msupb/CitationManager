namespace GUI
{
    partial class ManageCitationForm
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
            this.btGenerate = new System.Windows.Forms.Button();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbJournal = new System.Windows.Forms.TextBox();
            this.lblJournal = new System.Windows.Forms.Label();
            this.lblDoi = new System.Windows.Forms.Label();
            this.tbDoi = new System.Windows.Forms.TextBox();
            this.pnFirstName = new System.Windows.Forms.Panel();
            this.btAddAuthor = new System.Windows.Forms.Button();
            this.pnLastName = new System.Windows.Forms.Panel();
            this.grpAuthors = new System.Windows.Forms.GroupBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAuthors.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(367, 34);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 32;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.Generate);
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(217, 40);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(100, 20);
            this.tbPublisher.TabIndex = 31;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(111, 40);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 30;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(6, 40);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 29;
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(134, 18);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(30, 13);
            this.lblStyle.TabIndex = 26;
            this.lblStyle.Text = "Style";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 18);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "Type";
            // 
            // cbStyle
            // 
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Location = new System.Drawing.Point(137, 34);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(121, 21);
            this.cbStyle.TabIndex = 24;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(10, 34);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 23;
            this.cbType.SelectedValueChanged += new System.EventHandler(this.cbType_SelectedValueChanged);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(214, 24);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(50, 13);
            this.lblPublisher.TabIndex = 22;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(108, 24);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Title";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(121, 24);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First name";
            // 
            // tbJournal
            // 
            this.tbJournal.Location = new System.Drawing.Point(217, 40);
            this.tbJournal.Name = "tbJournal";
            this.tbJournal.Size = new System.Drawing.Size(100, 20);
            this.tbJournal.TabIndex = 34;
            // 
            // lblJournal
            // 
            this.lblJournal.AutoSize = true;
            this.lblJournal.Location = new System.Drawing.Point(214, 24);
            this.lblJournal.Name = "lblJournal";
            this.lblJournal.Size = new System.Drawing.Size(41, 13);
            this.lblJournal.TabIndex = 33;
            this.lblJournal.Text = "Journal";
            // 
            // lblDoi
            // 
            this.lblDoi.AutoSize = true;
            this.lblDoi.Location = new System.Drawing.Point(320, 24);
            this.lblDoi.Name = "lblDoi";
            this.lblDoi.Size = new System.Drawing.Size(23, 13);
            this.lblDoi.TabIndex = 35;
            this.lblDoi.Text = "Doi";
            // 
            // tbDoi
            // 
            this.tbDoi.Location = new System.Drawing.Point(323, 40);
            this.tbDoi.Name = "tbDoi";
            this.tbDoi.Size = new System.Drawing.Size(100, 20);
            this.tbDoi.TabIndex = 36;
            // 
            // pnFirstName
            // 
            this.pnFirstName.Location = new System.Drawing.Point(9, 40);
            this.pnFirstName.Name = "pnFirstName";
            this.pnFirstName.Size = new System.Drawing.Size(108, 313);
            this.pnFirstName.TabIndex = 37;
            // 
            // btAddAuthor
            // 
            this.btAddAuthor.Location = new System.Drawing.Point(286, 34);
            this.btAddAuthor.Name = "btAddAuthor";
            this.btAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btAddAuthor.TabIndex = 38;
            this.btAddAuthor.Text = "Add author";
            this.btAddAuthor.UseVisualStyleBackColor = true;
            this.btAddAuthor.Click += new System.EventHandler(this.btAddAuthor_Click);
            // 
            // pnLastName
            // 
            this.pnLastName.Location = new System.Drawing.Point(123, 40);
            this.pnLastName.Name = "pnLastName";
            this.pnLastName.Size = new System.Drawing.Size(108, 313);
            this.pnLastName.TabIndex = 38;
            // 
            // grpAuthors
            // 
            this.grpAuthors.Controls.Add(this.pnLastName);
            this.grpAuthors.Controls.Add(this.lblFirstName);
            this.grpAuthors.Controls.Add(this.lblLastName);
            this.grpAuthors.Controls.Add(this.pnFirstName);
            this.grpAuthors.Location = new System.Drawing.Point(13, 73);
            this.grpAuthors.Name = "grpAuthors";
            this.grpAuthors.Size = new System.Drawing.Size(240, 368);
            this.grpAuthors.TabIndex = 39;
            this.grpAuthors.TabStop = false;
            this.grpAuthors.Text = "Authors";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblTitle);
            this.grpDetails.Controls.Add(this.lblYear);
            this.grpDetails.Controls.Add(this.lblPublisher);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.tbDoi);
            this.grpDetails.Controls.Add(this.tbTitle);
            this.grpDetails.Controls.Add(this.lblDoi);
            this.grpDetails.Controls.Add(this.tbYear);
            this.grpDetails.Controls.Add(this.lblJournal);
            this.grpDetails.Controls.Add(this.tbJournal);
            this.grpDetails.Controls.Add(this.tbPublisher);
            this.grpDetails.Location = new System.Drawing.Point(262, 73);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(437, 368);
            this.grpDetails.TabIndex = 40;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Citation details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Year";
            // 
            // ManageCitationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 452);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpAuthors);
            this.Controls.Add(this.btAddAuthor);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Name = "ManageCitationForm";
            this.Text = "ManageCitationForm";
            this.grpAuthors.ResumeLayout(false);
            this.grpAuthors.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbJournal;
        private System.Windows.Forms.Label lblJournal;
        private System.Windows.Forms.Label lblDoi;
        private System.Windows.Forms.TextBox tbDoi;
        private System.Windows.Forms.Panel pnFirstName;
        private System.Windows.Forms.Button btAddAuthor;
        private System.Windows.Forms.Panel pnLastName;
        private System.Windows.Forms.GroupBox grpAuthors;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ComboBox cbType;
    }
}