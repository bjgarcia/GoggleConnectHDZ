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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoggleConnectHDZ
{
    public partial class MainForm : Form
    {
        internal string[] settings =
        {
            "192.168.004.104",
            "22",
            "root",
            "divimath"
        };

        public MainForm()
        {
            InitializeComponent();
            Font curentfont = base.Font;

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

            Shell goggleShell = new Shell(settings);
            //goggleShell.CreateFileList();
            //goggleShell.CopyFileToLocal();
            Shell.ReadFileList(this.tblMovieList);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            


        }

        private void savePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();    

            if(result == DialogResult.OK) 
            { 
                txtLocalFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
