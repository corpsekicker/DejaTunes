using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DejaTunes.Core.Services;

namespace DejaTunes.UI.WinForms
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
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
            IFileManagementService fileManagementService = new FileManagementService();
            List<FileInfo> files = fileManagementService.CollectFiles(this.textBoxFolder.Text,
                this.checkBoxSearchSubFolders.Checked);

            // Populate list box with files:
            this.listBoxSearchResults.Items.Clear();
            object[] enumerable = files.Select(x => (object)x.FullName).ToArray();
            this.listBoxSearchResults.Items.AddRange(enumerable);

            // Find Duplicates:
            List<FileInfo> duplicates = fileManagementService.FindDuplicates(files, checkBoxFindDuplicatesBySize.Checked);

            // Populate list box with duplicates:
            this.listBoxDuplicates.Items.Clear();
            enumerable = duplicates.Select(x => (object)x.FullName).ToArray();
            this.listBoxDuplicates.Items.AddRange(enumerable);
        }

        private void buttonDeleteSelected_Click(object sender, System.EventArgs e)
        {
            // User Confirmation 
            var dialogResult = MessageBox.Show(@"Are you sure you want to delete the selected duplicated files?",
                @"Confirm Selection Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // TODO: Make progress bar
            this.UseWaitCursor = true;
            long totalSize = 0;
            foreach (var selectedDuplicate in listBoxDuplicates.SelectedItems)
            {
                FileInfo fileInfo = new FileInfo(selectedDuplicate.ToString());
                totalSize += fileInfo.Length;
                File.Delete(selectedDuplicate.ToString());
            }
            this.UseWaitCursor = false;

            // Show summary
            MessageBox.Show($"Total Size of deleted files: {totalSize}", @"Duplicate Deletion Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
