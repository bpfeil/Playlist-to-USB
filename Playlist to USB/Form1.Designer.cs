namespace Playlist_to_USB
{
    partial class Playlist2USB
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
            this.inFile = new System.Windows.Forms.Button();
            this.InputPlaylist = new System.Windows.Forms.TextBox();
            this.SavePath = new System.Windows.Forms.TextBox();
            this.outFile = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.OutputPlaylist = new System.Windows.Forms.TextBox();
            this.SearchSequence = new System.Windows.Forms.TextBox();
            this.Actions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inFile
            // 
            this.inFile.Location = new System.Drawing.Point(485, 44);
            this.inFile.Name = "inFile";
            this.inFile.Size = new System.Drawing.Size(101, 23);
            this.inFile.TabIndex = 0;
            this.inFile.Text = "Open Playlist File";
            this.inFile.UseVisualStyleBackColor = true;
            this.inFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // InputPlaylist
            // 
            this.InputPlaylist.Location = new System.Drawing.Point(12, 46);
            this.InputPlaylist.Name = "InputPlaylist";
            this.InputPlaylist.Size = new System.Drawing.Size(467, 20);
            this.InputPlaylist.TabIndex = 1;
            // 
            // SavePath
            // 
            this.SavePath.Location = new System.Drawing.Point(12, 12);
            this.SavePath.Name = "SavePath";
            this.SavePath.Size = new System.Drawing.Size(467, 20);
            this.SavePath.TabIndex = 2;
            // 
            // outFile
            // 
            this.outFile.Location = new System.Drawing.Point(485, 10);
            this.outFile.Name = "outFile";
            this.outFile.Size = new System.Drawing.Size(101, 23);
            this.outFile.TabIndex = 3;
            this.outFile.Text = "USB Location";
            this.outFile.UseVisualStyleBackColor = true;
            this.outFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(485, 115);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(144, 30);
            this.Run.TabIndex = 4;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.button3_Click);
            // 
            // OutputPlaylist
            // 
            this.OutputPlaylist.Location = new System.Drawing.Point(13, 84);
            this.OutputPlaylist.Name = "OutputPlaylist";
            this.OutputPlaylist.Size = new System.Drawing.Size(466, 20);
            this.OutputPlaylist.TabIndex = 5;
            this.OutputPlaylist.Text = "Playlist";
            // 
            // SearchSequence
            // 
            this.SearchSequence.Location = new System.Drawing.Point(13, 121);
            this.SearchSequence.Name = "SearchSequence";
            this.SearchSequence.Size = new System.Drawing.Size(466, 20);
            this.SearchSequence.TabIndex = 8;
            this.SearchSequence.Text = "\\\\pfeilhomeserver\\itunes media\\music";
            // 
            // Actions
            // 
            this.Actions.AutoSize = true;
            this.Actions.Location = new System.Drawing.Point(485, 70);
            this.Actions.MaximumSize = new System.Drawing.Size(150, 100);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(37, 13);
            this.Actions.TabIndex = 0;
            this.Actions.Text = "Action";
            this.Actions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Playlist2USB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 157);
            this.Controls.Add(this.SearchSequence);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.OutputPlaylist);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.outFile);
            this.Controls.Add(this.SavePath);
            this.Controls.Add(this.InputPlaylist);
            this.Controls.Add(this.inFile);
            this.Name = "Playlist2USB";
            this.Text = "Playlist to USB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button inFile;
        private System.Windows.Forms.TextBox InputPlaylist;
        private System.Windows.Forms.TextBox SavePath;
        private System.Windows.Forms.Button outFile;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox OutputPlaylist;
        private System.Windows.Forms.TextBox SearchSequence;
        private System.Windows.Forms.Label Actions;
    }
}

