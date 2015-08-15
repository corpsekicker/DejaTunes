namespace DejaTunes.UI.WinForms
{
    partial class Shell
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
            this.labelStep1 = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonFolderBrowse = new System.Windows.Forms.Button();
            this.checkBoxSearchSubFolders = new System.Windows.Forms.CheckBox();
            this.buttonSearchForDuplicates = new System.Windows.Forms.Button();
            this.groupBoxSearchResults = new System.Windows.Forms.GroupBox();
            this.listBoxSearchResults = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxDuplicates = new System.Windows.Forms.ListBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.labelComboBoxSearchMethod = new System.Windows.Forms.Label();
            this.comboBoxSearchMethod = new System.Windows.Forms.ComboBox();
            this.buttonOpenLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchPattern = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxSearchResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Location = new System.Drawing.Point(12, 25);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(69, 13);
            this.labelStep1.TabIndex = 0;
            this.labelStep1.Text = "Search Path:";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolder.Location = new System.Drawing.Point(99, 22);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(483, 20);
            this.textBoxFolder.TabIndex = 2;
            // 
            // buttonFolderBrowse
            // 
            this.buttonFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolderBrowse.Location = new System.Drawing.Point(588, 20);
            this.buttonFolderBrowse.Name = "buttonFolderBrowse";
            this.buttonFolderBrowse.Size = new System.Drawing.Size(29, 23);
            this.buttonFolderBrowse.TabIndex = 3;
            this.buttonFolderBrowse.Text = "...";
            this.buttonFolderBrowse.UseVisualStyleBackColor = true;
            this.buttonFolderBrowse.Click += new System.EventHandler(this.buttonFolderBrowse_Click);
            // 
            // checkBoxSearchSubFolders
            // 
            this.checkBoxSearchSubFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSearchSubFolders.AutoSize = true;
            this.checkBoxSearchSubFolders.Location = new System.Drawing.Point(210, 52);
            this.checkBoxSearchSubFolders.Name = "checkBoxSearchSubFolders";
            this.checkBoxSearchSubFolders.Size = new System.Drawing.Size(114, 17);
            this.checkBoxSearchSubFolders.TabIndex = 4;
            this.checkBoxSearchSubFolders.Text = "Search sub-folders";
            this.checkBoxSearchSubFolders.UseVisualStyleBackColor = true;
            // 
            // buttonSearchForDuplicates
            // 
            this.buttonSearchForDuplicates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchForDuplicates.Location = new System.Drawing.Point(15, 75);
            this.buttonSearchForDuplicates.Name = "buttonSearchForDuplicates";
            this.buttonSearchForDuplicates.Size = new System.Drawing.Size(602, 23);
            this.buttonSearchForDuplicates.TabIndex = 6;
            this.buttonSearchForDuplicates.Text = "Search for Duplicates";
            this.buttonSearchForDuplicates.UseVisualStyleBackColor = true;
            this.buttonSearchForDuplicates.Click += new System.EventHandler(this.buttonSearchForDuplicates_Click);
            // 
            // groupBoxSearchResults
            // 
            this.groupBoxSearchResults.Controls.Add(this.listBoxSearchResults);
            this.groupBoxSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchResults.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchResults.Name = "groupBoxSearchResults";
            this.groupBoxSearchResults.Size = new System.Drawing.Size(602, 270);
            this.groupBoxSearchResults.TabIndex = 7;
            this.groupBoxSearchResults.TabStop = false;
            this.groupBoxSearchResults.Text = "Search Results";
            // 
            // listBoxSearchResults
            // 
            this.listBoxSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSearchResults.FormattingEnabled = true;
            this.listBoxSearchResults.Location = new System.Drawing.Point(3, 16);
            this.listBoxSearchResults.Name = "listBoxSearchResults";
            this.listBoxSearchResults.Size = new System.Drawing.Size(596, 251);
            this.listBoxSearchResults.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxDuplicates);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 252);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duplicated Files";
            // 
            // listBoxDuplicates
            // 
            this.listBoxDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDuplicates.FormattingEnabled = true;
            this.listBoxDuplicates.Location = new System.Drawing.Point(3, 16);
            this.listBoxDuplicates.Name = "listBoxDuplicates";
            this.listBoxDuplicates.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxDuplicates.Size = new System.Drawing.Size(596, 233);
            this.listBoxDuplicates.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(15, 104);
            this.splitContainer.MinimumSize = new System.Drawing.Size(514, 418);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBoxSearchResults);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer.Size = new System.Drawing.Size(602, 526);
            this.splitContainer.SplitterDistance = 270;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteAll.Location = new System.Drawing.Point(379, 3);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(220, 23);
            this.buttonDeleteAll.TabIndex = 7;
            this.buttonDeleteAll.Text = "Delete All Duplicates";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteSelected.Location = new System.Drawing.Point(192, 3);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(184, 23);
            this.buttonDeleteSelected.TabIndex = 8;
            this.buttonDeleteSelected.Text = "Delete Selected Duplicates";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // labelComboBoxSearchMethod
            // 
            this.labelComboBoxSearchMethod.AutoSize = true;
            this.labelComboBoxSearchMethod.Location = new System.Drawing.Point(330, 53);
            this.labelComboBoxSearchMethod.Name = "labelComboBoxSearchMethod";
            this.labelComboBoxSearchMethod.Size = new System.Drawing.Size(102, 13);
            this.labelComboBoxSearchMethod.TabIndex = 9;
            this.labelComboBoxSearchMethod.Text = "Duplication Method:";
            // 
            // comboBoxSearchMethod
            // 
            this.comboBoxSearchMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchMethod.FormattingEnabled = true;
            this.comboBoxSearchMethod.Location = new System.Drawing.Point(438, 50);
            this.comboBoxSearchMethod.Name = "comboBoxSearchMethod";
            this.comboBoxSearchMethod.Size = new System.Drawing.Size(179, 21);
            this.comboBoxSearchMethod.TabIndex = 10;
            // 
            // buttonOpenLocation
            // 
            this.buttonOpenLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenLocation.Location = new System.Drawing.Point(0, 3);
            this.buttonOpenLocation.Name = "buttonOpenLocation";
            this.buttonOpenLocation.Size = new System.Drawing.Size(189, 23);
            this.buttonOpenLocation.TabIndex = 11;
            this.buttonOpenLocation.Text = "Open Location";
            this.buttonOpenLocation.UseVisualStyleBackColor = true;
            this.buttonOpenLocation.Click += new System.EventHandler(this.buttonOpenLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Pattern:";
            // 
            // textBoxSearchPattern
            // 
            this.textBoxSearchPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchPattern.Location = new System.Drawing.Point(99, 50);
            this.textBoxSearchPattern.Name = "textBoxSearchPattern";
            this.textBoxSearchPattern.Size = new System.Drawing.Size(102, 20);
            this.textBoxSearchPattern.TabIndex = 13;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 673);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(629, 22);
            this.statusStrip.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOpenLocation);
            this.panel1.Controls.Add(this.buttonDeleteSelected);
            this.panel1.Controls.Add(this.buttonDeleteAll);
            this.panel1.Location = new System.Drawing.Point(15, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 34);
            this.panel1.TabIndex = 15;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxSearchPattern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSearchMethod);
            this.Controls.Add(this.labelComboBoxSearchMethod);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.buttonSearchForDuplicates);
            this.Controls.Add(this.checkBoxSearchSubFolders);
            this.Controls.Add(this.buttonFolderBrowse);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.labelStep1);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(645, 733);
            this.Name = "Shell";
            this.Text = "DejaTunes";
            this.groupBoxSearchResults.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonFolderBrowse;
        private System.Windows.Forms.CheckBox checkBoxSearchSubFolders;
        private System.Windows.Forms.Button buttonSearchForDuplicates;
        private System.Windows.Forms.GroupBox groupBoxSearchResults;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxSearchResults;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.ListBox listBoxDuplicates;
        private System.Windows.Forms.Label labelComboBoxSearchMethod;
        private System.Windows.Forms.ComboBox comboBoxSearchMethod;
        private System.Windows.Forms.Button buttonOpenLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchPattern;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panel1;
    }
}

