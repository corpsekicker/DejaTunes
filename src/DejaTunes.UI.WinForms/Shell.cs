using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DejaTunes.Core.Services;
using DejaTunes.Utilities;

namespace DejaTunes.UI.WinForms
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
            this.statusStrip.Text = @"Ready";
            this.PopulateSearchMethods();
        }

        private void PopulateSearchMethods()
        {
            this.comboBoxSearchMethod.ValueMember = "Key";
            this.comboBoxSearchMethod.DisplayMember = "Value";
            List<KeyValuePair<DuplicateSearchMethod, string>> valueDescriptions = EnumExtensions.GetEnumValueDescriptions<DuplicateSearchMethod>();
            this.comboBoxSearchMethod.DataSource = valueDescriptions;
        }

        //TODO: Cache
        private Dictionary<string, FileInfo> fileInfoByFileName = new Dictionary<string, FileInfo>();

        private void buttonFolderBrowse_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = @"Select folder within which to find duplicate files."
            };
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.textBoxFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonSearchForDuplicates_Click(object sender, System.EventArgs e)
        {
            // Validate Folder Path
            if (string.IsNullOrEmpty(textBoxFolder.Text) || !Directory.Exists(textBoxFolder.Text))
            {
                MessageBox.Show(@"Please select a valid folder path.", @"Invalid Folder Path", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Collect files at folder.
            this.UseWaitCursor = true;
            this.statusStrip.Text = @"Busy";
            IFileManagementService fileManagementService = new FileManagementService();
            List<FileInfo> files = fileManagementService.CollectFiles(this.textBoxFolder.Text, this.checkBoxSearchSubFolders.Checked, textBoxSearchPattern.Text);
            this.UseWaitCursor = false;
            this.statusStrip.Text = @"Ready";

            // Populate list box with files:
            this.listBoxSearchResults.Items.Clear();
            object[] enumerable = files.Select(x => (object)x.FullName).ToArray();
            this.listBoxSearchResults.Items.AddRange(enumerable);

            // Find Duplicates:
            List<FileInfo> duplicates = fileManagementService.FindDuplicates(files, ((KeyValuePair<DuplicateSearchMethod, string>) comboBoxSearchMethod.SelectedItem).Key);
            

            // Populate list box with duplicates:
            this.listBoxDuplicates.Items.Clear();
            enumerable = duplicates.Select(x => (object)x.FullName).ToArray();
            this.listBoxDuplicates.Items.AddRange(enumerable);
        }

        private void buttonDeleteSelected_Click(object sender, System.EventArgs e)
        {
            // User Confirmation 
            var dialogResult = MessageBox.Show($"Are you sure you want to delete the selected {listBoxDuplicates.SelectedItems.Count} duplicated file(s)?",
                @"Confirm Selection Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // TODO: Make progress bar
            this.UseWaitCursor = true;
            this.statusStrip.Text = @"Busy";
            DeleteFiles(listBoxDuplicates.SelectedItems.Cast<object>().Select(x => x.ToString()));
        }

        private void DeleteFiles(IEnumerable<string> files)
        {
            long totalSize = 0;
            foreach (var selectedDuplicate in files)
            {
                FileInfo fileInfo = new FileInfo(selectedDuplicate);
                totalSize += fileInfo.Length;
                File.Delete(selectedDuplicate);
            }
            this.UseWaitCursor = false;
            this.statusStrip.Text = @"Ready";

            // Show summary
            string size = GetFormattedSize(totalSize);
            MessageBox.Show($"Total Size of deleted files: {size}", @"Duplicate Deletion Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetFormattedSize(long totalSize)
        {
            if (totalSize < 1024)
            {
                return $"{totalSize} Bytes";
            }

            if (totalSize < 1024 * 1024)
            {
                return $"{ (totalSize/1024)} Kilobytes";
            }

            if (totalSize < 1024 * 1024 * 1024)
            {
                return $"{ (totalSize / 1024)} Megabytes";
            }

            throw new InvalidOperationException($"{totalSize} is too small.");
        }

        private void buttonOpenLocation_Click(object sender, EventArgs e)
        {
            if (this.listBoxDuplicates.SelectedItems.Count != 1)
            {
                return;
            }

            var fileInfo = new FileInfo(this.listBoxDuplicates.SelectedItems[0].ToString());
            Process.Start(@fileInfo.Directory.FullName);
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            // User Confirmation 
            var dialogResult = MessageBox.Show(@"Are you sure you want to delete ALL the duplicated files?",
                @"Confirm Selection Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // TODO: Make progress bar
            this.UseWaitCursor = true;
            DeleteFiles(listBoxDuplicates.Items.Cast<object>().Select(x => x.ToString()));
        }
    }
}
