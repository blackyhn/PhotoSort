using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhotoSort
{
    public partial class Form1 : Form
    {

        FileManager fileManager;

        public Form1()
        {
            InitializeComponent();
            this.fileManager = new FileManager();

            this.folderPattern.Text = fileManager.NewFolderName;
            this.namePattern.Text = fileManager.NewFileName;
            this.extensions.Text = fileManager.PhotoMask;
            this.videoExtensions.Text = fileManager.VideoMask;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //Select folder to add
            if ( folderBrowser.ShowDialog() == DialogResult.OK )
            {
                String folderName = folderBrowser.SelectedPath;
                
                //Check of exists 
                if ( !foldersListBox.Items.Contains(folderName) )
                    foldersListBox.Items.Add(folderName);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

            //Remove the selected forlder
            if ( foldersListBox.SelectedIndex > 0 ){
                foldersListBox.Items.RemoveAt( foldersListBox.SelectedIndex );
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            this.fileManager.NewFileName = this.namePattern.Text;
            this.fileManager.NewFolderName = this.folderPattern.Text;
            this.fileManager.PhotoMask = this.extensions.Text;
            this.fileManager.VideoMask = this.videoExtensions.Text;
            foreach (string folder in foldersListBox.Items)
            {
                this.fileManager.scanFolder(folder,this.addVideos.Checked);
            }
            this.foldersListBox.Items.Clear();
            this.filesLoadedLabel.Text = this.fileManager.MediaList.Count.ToString();
            this.progressBar.Maximum = this.fileManager.MediaList.Count;
            if (DialogResult.OK == MessageBox.Show(this.fileManager.MediaList.Count.ToString() + " files are loaded.Are you sure?", "Export files", MessageBoxButtons.OKCancel))
            {
                this.fileManager.MoveFiles = this.moveFiles.Checked;
                this.fileManager.exportPhotos(increaseProgress);
            }
                
            //foreach (SingleImage node in this.fileManager.ImagesList) { Console.WriteLine(node.DateTaken); }
        }

        private void destinationBtn_Click(object sender, EventArgs e)
        {
            //Select destination folder
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    String folderName = folderBrowser.SelectedPath;

                    //Check of exists 
                    this.fileManager.PhotoDestinationFolder = folderName;
                    destinationBtn.Text = folderName;
                }
            }
        }

        public void increaseProgress()
        {
            this.progressBar.Value++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reset the program
            this.fileManager = new FileManager();
            this.progressBar.Value = 0;
            this.filesLoadedLabel.Text = "0";
            this.destinationBtn.Text = "Select Destination Folder";
        }
                
    }
}
