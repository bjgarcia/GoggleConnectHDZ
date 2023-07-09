using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoggleConnectHDZ
{
    public partial class MainForm : Form
    {
        internal string[] settings =
        {
            "192.168.004.104",
            "22",
            "root",
            "divimath",
            "c:\temp"
        };

     

        public MainForm()
        {
            InitializeComponent();
            Font curentfont = base.Font;

            int tmargin = 35;
            int rmargin = 24;
            int lheight = 460;
            int lwidth = 500;
            int rwidth = 24;
            int rheight = 24;
            
            LPanel.Location = new Point(rmargin, tmargin);
            LPanel.Size = new Size(new Point(lwidth,lheight));

            RPanel.Location = new Point(555, tmargin);
            RPanel.Height = 460;

            int footlevel = 505;
            lblSavePath.Location = new Point(rmargin, footlevel);
            txtSavePath.Location = new Point(80, footlevel);

            lblIPAddress.Location = new Point(400, footlevel);
            txtIPAddress.Location = new Point(500, footlevel);

            // initialize table
            this.tblMovieList.Controls.Add(new Label() { Font = new Font(curentfont, FontStyle.Bold), Text = "File Name", TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
            this.tblMovieList.Controls.Add(new Label() { Font = new Font(curentfont, FontStyle.Bold), Text = "Created", TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
            this.tblMovieList.Controls.Add(new Label() { Font = new Font(curentfont, FontStyle.Bold), Text = "File Size", TextAlign = ContentAlignment.MiddleCenter }, 2, 0);
            this.tblMovieList.Controls.Add(new Label() {}, 3, 0);
            this.tblMovieList.Controls.Add(new Label() {}, 4, 0);
            this.tblMovieList.Controls.Add(new Label() {}, 5, 0);
            settings = Shell.LoadSettings(settings);
            txtIPAddress.Text = settings[0];
            txtUser.Text = settings[2];
            txtPassword.PasswordChar = '*';
            txtPassword.Text = settings[3];
            txtSavePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);


            Shell goggleShell = new Shell(settings);
            //goggleShell.CreateFileList();
            //goggleShell.CopyFileToLocal(Path.Combine("//tmp//", Shell.MovieList), Path.Combine(Path.GetTempPath(), Shell.MovieList));
            ReadFileList(this.tblMovieList);
            AssignLinkLabelHandler(this.tblMovieList);
        }

        public void AssignLinkLabelHandler(TableLayoutPanel table)
        {
            foreach (var crtl in table.Controls.OfType<LinkLabel>())
            {
                if (crtl.Name.Contains("_F"))
                {
                    crtl.LinkClicked += new LinkLabelLinkClickedEventHandler(this.OpenFileLinkClicked);
                }

                if (crtl.Name.Contains("_C"))
                {
                    crtl.LinkClicked += new LinkLabelLinkClickedEventHandler(this.CopyFileLinkClicked);
                }

                if (crtl.Name.Contains("_D"))
                {
                    crtl.LinkClicked += new LinkLabelLinkClickedEventHandler(this.DeleteFileLinkClicked);
                }
            }
        }

        public ProgressBar GetProgressBar(TableLayoutPanel table, string name)
        {
            return table.Controls.OfType<ProgressBar>().Where(x => x.Name == name).FirstOrDefault();
        }

        public void ReadFileList(TableLayoutPanel table)
        {
            RowStyle hStyle = table.RowStyles[table.RowCount - 1];

            using (StreamReader sr = new StreamReader(Path.Combine(Path.GetTempPath(), Shell.MovieList)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    table.RowCount++;
                    table.RowStyles.Add(new RowStyle(hStyle.SizeType, hStyle.Height));

                    string[] field = line.Split(new char[] { ' ' });
                    string name = field[4].Split(new char[] { '.' })[0];
                    string size = (Math.Round(Double.Parse(field[0]) / Math.Pow(1024, 2), 1)).ToString() + " MB";
                    var date = DateTime.Parse($"{field[1]} {field[2]}{field[3]}");

                    table.Controls.Add(new LinkLabel() { Name = name + "_F", Text = field[4], TextAlign = ContentAlignment.MiddleLeft }, 0, table.RowCount - 1);
                    table.Controls.Add(new Label() { Text = date.ToString().Trim(), TextAlign = ContentAlignment.MiddleLeft }, 1, table.RowCount - 1);
                    table.Controls.Add(new Label() { Text = size, TextAlign = ContentAlignment.MiddleRight }, 2, table.RowCount - 1);
                    table.Controls.Add(new LinkLabel() { Name = name + "_C", Text = "C", TextAlign = ContentAlignment.MiddleLeft }, 3, table.RowCount - 1);
                    table.Controls.Add(new LinkLabel() { Name = name + "_D", Text = "D", TextAlign = ContentAlignment.MiddleLeft }, 4, table.RowCount - 1);
                    table.Controls.Add(new ProgressBar() { Name = name + "_P" }, 5, table.RowCount - 1);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            



        }

        private void OpenFileLinkClicked(object sender, EventArgs e)
        { 
     
        }

        private void CopyFileLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = (sender as LinkLabel);
            linkLabel.Enabled = false;
            string fileName = linkLabel.Name.Substring(0, linkLabel.Name.Length - 2);
            var progressBar = GetProgressBar(tblMovieList, $"{fileName}_P");
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 19;    
            
            string localFile = Path.GetFullPath($"{settings[4]}/{fileName}.ts");
            string remoteFile = $"//mnt//extsd//movies/{fileName}.ts";
            /// mnt / extsd / movies
            //await Shell.CopyFileToLocalAsync(remoteFile, localFile, settings);
          
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar.Maximum;
            linkLabel.Enabled = true;
        }

        private void DeleteFileLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = (sender as LinkLabel);
            linkLabel.Enabled = false;
            string fileName = linkLabel.Name.Substring(0, linkLabel.Name.Length - 2);
            var progressBar = GetProgressBar(tblMovieList, $"{fileName}_P");
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 19;

            string localFile = Path.GetFullPath($"{settings[4]}/{fileName}.ts");
            string remoteFile = $"//mnt//extsd//movies/{fileName}.ts";
            var info = Shell.CopyFileToLocal(remoteFile, localFile, settings);

            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Value = progressBar.Maximum;
            linkLabel.Enabled = true;

        }

        private void savePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void txtLocalFolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSavePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
