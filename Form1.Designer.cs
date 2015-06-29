namespace PhotoSort
{
    partial class Form1
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
            this.foldersListBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.convertBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.destinationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderPattern = new System.Windows.Forms.TextBox();
            this.namePattern = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moveFiles = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.extensions = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filesLoadedLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.videoExtensions = new System.Windows.Forms.TextBox();
            this.addVideos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // foldersListBox
            // 
            this.foldersListBox.FormattingEnabled = true;
            this.foldersListBox.ItemHeight = 25;
            this.foldersListBox.Location = new System.Drawing.Point(12, 89);
            this.foldersListBox.Name = "foldersListBox";
            this.foldersListBox.Size = new System.Drawing.Size(678, 204);
            this.foldersListBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(12, 24);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 59);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(93, 24);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 59);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "-";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // convertBtn
            // 
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(12, 389);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(577, 60);
            this.convertBtn.TabIndex = 3;
            this.convertBtn.Text = "Start";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 470);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1244, 55);
            this.progressBar.TabIndex = 5;
            // 
            // destinationBtn
            // 
            this.destinationBtn.Location = new System.Drawing.Point(12, 309);
            this.destinationBtn.Name = "destinationBtn";
            this.destinationBtn.Size = new System.Drawing.Size(678, 60);
            this.destinationBtn.TabIndex = 6;
            this.destinationBtn.Text = "Select Destination Folder";
            this.destinationBtn.UseVisualStyleBackColor = true;
            this.destinationBtn.Click += new System.EventHandler(this.destinationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Destination Folder Pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(729, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destination Name Pattern";
            // 
            // folderPattern
            // 
            this.folderPattern.Location = new System.Drawing.Point(729, 85);
            this.folderPattern.Name = "folderPattern";
            this.folderPattern.Size = new System.Drawing.Size(532, 31);
            this.folderPattern.TabIndex = 9;
            // 
            // namePattern
            // 
            this.namePattern.Location = new System.Drawing.Point(729, 184);
            this.namePattern.Name = "namePattern";
            this.namePattern.Size = new System.Drawing.Size(532, 31);
            this.namePattern.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Example: new\\[[y]]\\[[m]]\\[[d]]\\ gives \"new\\2015\\1\\23";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(493, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Example: pic_[[h]]_[[min]]_[[s]] gives: pic_3_23_56";
            // 
            // moveFiles
            // 
            this.moveFiles.AutoSize = true;
            this.moveFiles.Location = new System.Drawing.Point(1036, 384);
            this.moveFiles.Name = "moveFiles";
            this.moveFiles.Size = new System.Drawing.Size(149, 29);
            this.moveFiles.TabIndex = 13;
            this.moveFiles.Text = "Move Files";
            this.moveFiles.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Photo files extensions:";
            // 
            // extensions
            // 
            this.extensions.Location = new System.Drawing.Point(734, 268);
            this.extensions.Name = "extensions";
            this.extensions.Size = new System.Drawing.Size(527, 31);
            this.extensions.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(724, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Files loaded:";
            // 
            // filesLoadedLabel
            // 
            this.filesLoadedLabel.AutoSize = true;
            this.filesLoadedLabel.Location = new System.Drawing.Point(896, 407);
            this.filesLoadedLabel.Name = "filesLoadedLabel";
            this.filesLoadedLabel.Size = new System.Drawing.Size(24, 25);
            this.filesLoadedLabel.TabIndex = 17;
            this.filesLoadedLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 60);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Video files extensions:";
            // 
            // videoExtensions
            // 
            this.videoExtensions.Location = new System.Drawing.Point(734, 335);
            this.videoExtensions.Name = "videoExtensions";
            this.videoExtensions.Size = new System.Drawing.Size(527, 31);
            this.videoExtensions.TabIndex = 20;
            // 
            // addVideos
            // 
            this.addVideos.AutoSize = true;
            this.addVideos.Checked = true;
            this.addVideos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addVideos.Location = new System.Drawing.Point(1036, 420);
            this.addVideos.Name = "addVideos";
            this.addVideos.Size = new System.Drawing.Size(196, 29);
            this.addVideos.TabIndex = 21;
            this.addVideos.Text = "Scan video files";
            this.addVideos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 543);
            this.Controls.Add(this.addVideos);
            this.Controls.Add(this.videoExtensions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filesLoadedLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.extensions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.moveFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namePattern);
            this.Controls.Add(this.folderPattern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.foldersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PhotoSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox foldersListBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button destinationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox folderPattern;
        private System.Windows.Forms.TextBox namePattern;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox moveFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox extensions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label filesLoadedLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox videoExtensions;
        private System.Windows.Forms.CheckBox addVideos;
    }
}

