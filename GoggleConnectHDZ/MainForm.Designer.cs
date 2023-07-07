using System.Windows.Forms;

namespace GoggleConnectHDZ
{
    partial class MainForm
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
            this.LPanel = new System.Windows.Forms.Panel();
            this.tblMovieList = new System.Windows.Forms.TableLayoutPanel();
            this.RPanel = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnIPAddress = new System.Windows.Forms.Button();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.savePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLocalFolder = new System.Windows.Forms.TextBox();
            this.lblLocalFolder = new System.Windows.Forms.Label();
            this.LPanel.SuspendLayout();
            this.RPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LPanel
            // 
            this.LPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LPanel.BackColor = System.Drawing.SystemColors.Window;
            this.LPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LPanel.Controls.Add(this.tblMovieList);
            this.LPanel.Location = new System.Drawing.Point(18, 43);
            this.LPanel.Name = "LPanel";
            this.LPanel.Size = new System.Drawing.Size(525, 502);
            this.LPanel.TabIndex = 0;
            // 
            // tblMovieList
            // 
            this.tblMovieList.AutoScroll = true;
            this.tblMovieList.AutoSize = true;
            this.tblMovieList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMovieList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMovieList.ColumnCount = 6;
            this.tblMovieList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tblMovieList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblMovieList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblMovieList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tblMovieList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tblMovieList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tblMovieList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblMovieList.Location = new System.Drawing.Point(20, 18);
            this.tblMovieList.Name = "tblMovieList";
            this.tblMovieList.RowCount = 1;
            this.tblMovieList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMovieList.Size = new System.Drawing.Size(487, 32);
            this.tblMovieList.TabIndex = 0;
            // 
            // RPanel
            // 
            this.RPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RPanel.BackColor = System.Drawing.SystemColors.Window;
            this.RPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RPanel.Controls.Add(this.lblPassword);
            this.RPanel.Controls.Add(this.lblUser);
            this.RPanel.Controls.Add(this.txtUser);
            this.RPanel.Controls.Add(this.txtPassword);
            this.RPanel.Controls.Add(this.btnIPAddress);
            this.RPanel.Controls.Add(this.lblIPAddress);
            this.RPanel.Controls.Add(this.txtIPAddress);
            this.RPanel.Location = new System.Drawing.Point(555, 43);
            this.RPanel.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.RPanel.Name = "RPanel";
            this.RPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RPanel.Size = new System.Drawing.Size(260, 502);
            this.RPanel.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(23, 82);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 15);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Host User";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(110, 82);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(128, 21);
            this.txtUser.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(110, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(128, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // btnIPAddress
            // 
            this.btnIPAddress.Location = new System.Drawing.Point(163, 26);
            this.btnIPAddress.Name = "btnIPAddress";
            this.btnIPAddress.Size = new System.Drawing.Size(75, 23);
            this.btnIPAddress.TabIndex = 4;
            this.btnIPAddress.Text = "Save Address";
            this.btnIPAddress.UseVisualStyleBackColor = true;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(13, 18);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(121, 16);
            this.lblIPAddress.TabIndex = 3;
            this.lblIPAddress.Text = "Goggle IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(16, 38);
            this.txtIPAddress.Mask = "###.###.###.###";
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(128, 26);
            this.txtIPAddress.TabIndex = 2;
            this.txtIPAddress.ValidatingType = typeof(System.Net.IPAddress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePathToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // savePathToolStripMenuItem
            // 
            this.savePathToolStripMenuItem.Name = "savePathToolStripMenuItem";
            this.savePathToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.savePathToolStripMenuItem.Text = "Set File Save Path";
            this.savePathToolStripMenuItem.Click += new System.EventHandler(this.savePathToolStripMenuItem_Click);
            // 
            // txtLocalFolder
            // 
            this.txtLocalFolder.Location = new System.Drawing.Point(370, 12);
            this.txtLocalFolder.Name = "txtLocalFolder";
            this.txtLocalFolder.Size = new System.Drawing.Size(445, 20);
            this.txtLocalFolder.TabIndex = 3;
            // 
            // lblLocalFolder
            // 
            this.lblLocalFolder.AutoSize = true;
            this.lblLocalFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalFolder.Location = new System.Drawing.Point(253, 12);
            this.lblLocalFolder.Name = "lblLocalFolder";
            this.lblLocalFolder.Size = new System.Drawing.Size(104, 13);
            this.lblLocalFolder.TabIndex = 4;
            this.lblLocalFolder.Text = "Movie Save Path";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(878, 565);
            this.Controls.Add(this.lblLocalFolder);
            this.Controls.Add(this.txtLocalFolder);
            this.Controls.Add(this.RPanel);
            this.Controls.Add(this.LPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "GoggleConnectHDZ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LPanel.ResumeLayout(false);
            this.LPanel.PerformLayout();
            this.RPanel.ResumeLayout(false);
            this.RPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LPanel;
        private System.Windows.Forms.Panel RPanel;
        private System.Windows.Forms.TableLayoutPanel tblMovieList;
        private System.Windows.Forms.MaskedTextBox txtIPAddress;
        private Label lblIPAddress;
        private Button btnIPAddress;
        private Label lblUser;
        private TextBox txtUser;
        private MaskedTextBox txtPassword;
        private Label lblPassword;
        private FolderBrowserDialog folderBrowserDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem savePathToolStripMenuItem;
        private TextBox txtLocalFolder;
        private Label lblLocalFolder;
    }
}

