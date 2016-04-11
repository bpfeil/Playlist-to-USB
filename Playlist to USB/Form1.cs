using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Playlist_to_USB
{
    public partial class Playlist2USB : Form
    {
        public Playlist2USB()
        {
            InitializeComponent();
        }
        
        OpenFileDialog ofd = new OpenFileDialog();
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        private void button1_Click_1(object sender, EventArgs e)
        {

            ofd.Filter = "m3u/xml/txt| *.m3u; *.xml; *.txt| .m3u|*.m3u; |.xml|*.xml; |.txt|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                InputPlaylist.Text = ofd.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actions.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                SavePath.Text = fbd.SelectedPath;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actions.Text = "Executing....";
            Actions.Refresh();

            int counter = 0;
            string line;

            string savePath = SavePath.Text;
            string playlistFolder = savePath + "\\Playlists\\";
            string musicFolder = savePath + "\\Music\\";
            string search = SearchSequence.Text;
            //string search = @"\\pfeilhomeserver\itunes media\music";
            string playlistName = OutputPlaylist.Text;

            if (playlistName == "Playlist")
            {
                string[] name = InputPlaylist.Text.Split(new[] { "\\" }, StringSplitOptions.None);
                int j = name.Count();
                name = name[j-1].Split(new[] { "." }, StringSplitOptions.None);
                playlistName = name[0];

            }

            Actions.Text = "Ensuring directories are set up";
            Actions.Refresh();

            if (!System.IO.Directory.Exists(playlistFolder))
            {
                System.IO.Directory.CreateDirectory(playlistFolder);
            }
            if(!System.IO.Directory.Exists(musicFolder))
            {
                System.IO.Directory.CreateDirectory(musicFolder);
            }

            try
            {
                System.IO.StreamWriter outFile = new System.IO.StreamWriter(playlistFolder + playlistName + ".m3u");
                outFile.WriteLine("#Playlist '" + playlistName + "' created by Playlist to USB by Ben Pfeil");

                System.IO.StreamReader playlistFile = new System.IO.StreamReader(InputPlaylist.Text);

                while ((line = playlistFile.ReadLine()) != null)
                {

                    if (line.ToUpper().Contains(search.ToUpper()))
                    {
                        string[] output = line.Split(new[] { "\\" }, StringSplitOptions.None);

                        int i = output.Count();
                        
                        String stuff = "\\Music\\" + output[i - 3] + "\\" + output[i - 2] + "\\" + output[i - 1] + "\r\n";
                        String artistPath = musicFolder + output[i - 3];
                        String albumPath = artistPath + "\\" + output[i - 2];
                        String track = output[i - 1];
                        String trackPath = albumPath + "\\" + track;

                        Actions.Text = "Found " + track;
                        Actions.Refresh();

                        //File Copy Stuff
                        if (!System.IO.Directory.Exists(artistPath))
                        {
                            System.IO.Directory.CreateDirectory(artistPath);
                        }
                        if (!System.IO.Directory.Exists(albumPath))
                        {
                            System.IO.Directory.CreateDirectory(albumPath);
                        }

                        if (!System.IO.File.Exists(trackPath))
                        {
                            Actions.Text = "Copying " + track;
                            Actions.Refresh();
                            Console.WriteLine("Copying " + track);
                            System.IO.File.Copy(line, trackPath);
                            Console.WriteLine("Copying File Complete");
                        }
                        else
                        {
                            Console.WriteLine("Already exists - " + track + " skipping copying");
                        }

                        Console.Write(stuff);
                        outFile.Write(stuff);

                    }
                    counter++;
                }
                playlistFile.Close();
                outFile.Close();

                //Console.ReadLine();
                Actions.Text = "Complete";
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
