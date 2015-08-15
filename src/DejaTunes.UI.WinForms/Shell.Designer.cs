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
            this.labelStep2 = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonFolderBrowse = new System.Windows.Forms.Button();
            this.checkBoxSearchSubFolders = new System.Windows.Forms.CheckBox();
            this.checkBoxFindDuplicatesBySize = new System.Windows.Forms.CheckBox();
            this.buttonSearchForDuplicates = new System.Windows.Forms.Button();
            this.groupBoxSearchResults = new System.Windows.Forms.GroupBox();
            this.listBoxSearchResults = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.groupBoxSearchResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStep1
            // 
            this.labelStep1.AutoSize = true;
            this.labelStep1.Location = new System.Drawing.Point(12, 25);
            this.labelStep1.Name = "labelStep1";
            this.labelStep1.Size = new System.Drawing.Size(41, 13);
            this.labelStep1.TabIndex = 0;
            this.labelStep1.Text = "Step 1:";
            // 
            // labelStep2
            // 
            this.labelStep2.AutoSize = true;
            this.labelStep2.Location = new System.Drawing.Point(12, 53);
            this.labelStep2.Name = "labelStep2";
            this.labelStep2.Size = new System.Drawing.Size(41, 13);
            this.labelStep2.TabIndex = 1;
            this.labelStep2.Text = "Step 2:";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolder.Location = new System.Drawing.Point(59, 22);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(435, 20);
            this.textBoxFolder.TabIndex = 2;
            // 
            // buttonFolderBrowse
            // 
            this.buttonFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolderBrowse.Location = new System.Drawing.Point(500, 20);
            this.buttonFolderBrowse.Name = "buttonFolderBrowse";
            this.buttonFolderBrowse.Size = new System.Drawing.Size(29, 23);
            this.buttonFolderBrowse.TabIndex = 3;
            this.buttonFolderBrowse.Text = "...";
            this.buttonFolderBrowse.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchSubFolders
            // 
            this.checkBoxSearchSubFolders.AutoSize = true;
            this.checkBoxSearchSubFolders.Location = new System.Drawing.Point(59, 52);
            this.checkBoxSearchSubFolders.Name = "checkBoxSearchSubFolders";
            this.checkBoxSearchSubFolders.Size = new System.Drawing.Size(114, 17);
            this.checkBoxSearchSubFolders.TabIndex = 4;
            this.checkBoxSearchSubFolders.Text = "Search sub-folders";
            this.checkBoxSearchSubFolders.UseVisualStyleBackColor = true;
            // 
            // checkBoxFindDuplicatesBySize
            // 
            this.checkBoxFindDuplicatesBySize.AutoSize = true;
            this.checkBoxFindDuplicatesBySize.Location = new System.Drawing.Point(179, 52);
            this.checkBoxFindDuplicatesBySize.Name = "checkBoxFindDuplicatesBySize";
            this.checkBoxFindDuplicatesBySize.Size = new System.Drawing.Size(150, 17);
            this.checkBoxFindDuplicatesBySize.TabIndex = 5;
            this.checkBoxFindDuplicatesBySize.Text = "Find Duplicates by file size";
            this.checkBoxFindDuplicatesBySize.UseVisualStyleBackColor = true;
            // 
            // buttonSearchForDuplicates
            // 
            this.buttonSearchForDuplicates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchForDuplicates.Location = new System.Drawing.Point(15, 75);
            this.buttonSearchForDuplicates.Name = "buttonSearchForDuplicates";
            this.buttonSearchForDuplicates.Size = new System.Drawing.Size(514, 23);
            this.buttonSearchForDuplicates.TabIndex = 6;
            this.buttonSearchForDuplicates.Text = "Search for Duplicates";
            this.buttonSearchForDuplicates.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchResults
            // 
            this.groupBoxSearchResults.Controls.Add(this.listBoxSearchResults);
            this.groupBoxSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchResults.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchResults.Name = "groupBoxSearchResults";
            this.groupBoxSearchResults.Size = new System.Drawing.Size(514, 248);
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
            this.listBoxSearchResults.Size = new System.Drawing.Size(508, 229);
            this.listBoxSearchResults.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 229);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duplicated Files";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.Size,
            this.DateModified});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(508, 210);
            this.dataGridView.TabIndex = 0;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.Width = 300;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // DateModified
            // 
            this.DateModified.HeaderText = "Date Modified";
            this.DateModified.Name = "DateModified";
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
            this.splitContainer.Size = new System.Drawing.Size(514, 481);
            this.splitContainer.SplitterDistance = 248;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteAll.Location = new System.Drawing.Point(267, 591);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(259, 23);
            this.buttonDeleteAll.TabIndex = 7;
            this.buttonDeleteAll.Text = "Delete All Duplicates";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteSelected.Location = new System.Drawing.Point(15, 591);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(246, 23);
            this.buttonDeleteSelected.TabIndex = 8;
            this.buttonDeleteSelected.Text = "Delete Selected Duplicates";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 622);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.buttonSearchForDuplicates);
            this.Controls.Add(this.checkBoxFindDuplicatesBySize);
            this.Controls.Add(this.checkBoxSearchSubFolders);
            this.Controls.Add(this.buttonFolderBrowse);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.labelStep2);
            this.Controls.Add(this.labelStep1);
            this.MinimumSize = new System.Drawing.Size(557, 597);
            this.Name = "Shell";
            this.Text = "DejaTunes";
            this.groupBoxSearchResults.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStep1;
        private System.Windows.Forms.Label labelStep2;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonFolderBrowse;
        private System.Windows.Forms.CheckBox checkBoxSearchSubFolders;
        private System.Windows.Forms.CheckBox checkBoxFindDuplicatesBySize;
        private System.Windows.Forms.Button buttonSearchForDuplicates;
        private System.Windows.Forms.GroupBox groupBoxSearchResults;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxSearchResults;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateModified;
    }
}

