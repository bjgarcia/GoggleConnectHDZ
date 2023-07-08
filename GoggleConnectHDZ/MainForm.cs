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
            "c:/temp"

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
            txtLocalFolder.Text = settings[4];

            Shell goggleShell = new Shell(settings);
            //goggleShell.CreateFileList();
            //goggleShell.CopyFileToLocal();
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

        public void ReadFileList(TableLayoutPanel table)
        {
            RowStyle hStyle = table.RowStyles[table.RowCount - 1];

            using (StreamReader sr = new StreamReader(Shell.LocalList))
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

        private void OpenFileLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            
            
        }

        private void CopyFileLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void DeleteFileLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
