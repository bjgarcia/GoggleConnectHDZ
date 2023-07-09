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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.lblNetStat = new System.Windows.Forms.Label();
            this.txtNotification = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LPanel.SuspendLayout();
            this.RPanel.SuspendLayout();
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
            this.LPanel.Size = new System.Drawing.Size(525, 460);
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
            this.tblMovieList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblMovieList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblMovieList.Location = new System.Drawing.Point(20, 18);
            this.tblMovieList.Name = "tblMovieList";
            this.tblMovieList.RowCount = 1;
            this.tblMovieList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblMovieList.Size = new System.Drawing.Size(470, 37);
            this.tblMovieList.TabIndex = 0;
            // 
            // RPanel
            // 
            this.RPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RPanel.BackColor = System.Drawing.SystemColors.Window;
            this.RPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RPanel.Controls.Add(this.btnSave);
            this.RPanel.Controls.Add(this.lblPassword);
            this.RPanel.Controls.Add(this.lblUser);
            this.RPanel.Controls.Add(this.txtUser);
            this.RPanel.Controls.Add(this.txtPassword);
            this.RPanel.Controls.Add(this.btnConnect);
            this.RPanel.Location = new System.Drawing.Point(555, 43);
            this.RPanel.Margin = new System.Windows.Forms.Padding(3, 10, 20, 10);
            this.RPanel.Name = "RPanel";
            this.RPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RPanel.Size = new System.Drawing.Size(260, 460);
            this.RPanel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(151, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 45);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(23, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 15);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(26, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(94, 21);
            this.txtUser.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(26, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(94, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(151, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(675, 509);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(65, 15);
            this.lblIPAddress.TabIndex = 3;
            this.lblIPAddress.Text = "IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(678, 526);
            this.txtIPAddress.Mask = "###.###.###.###";
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(128, 26);
            this.txtIPAddress.TabIndex = 2;
            this.txtIPAddress.ValidatingType = typeof(System.Net.IPAddress);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavePath.Location = new System.Drawing.Point(92, 12);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(404, 21);
            this.txtSavePath.TabIndex = 3;
            this.txtSavePath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtLocalFolder_MouseDoubleClick);
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavePath.Location = new System.Drawing.Point(24, 12);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(62, 15);
            this.lblSavePath.TabIndex = 4;
            this.lblSavePath.Text = "Save Path";
            // 
            // lblNetStat
            // 
            this.lblNetStat.AutoSize = true;
            this.lblNetStat.Location = new System.Drawing.Point(561, 511);
            this.lblNetStat.Name = "lblNetStat";
            this.lblNetStat.Size = new System.Drawing.Size(80, 13);
            this.lblNetStat.TabIndex = 6;
            this.lblNetStat.Text = "Network Status";
            // 
            // txtNotification
            // 
            this.txtNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotification.Location = new System.Drawing.Point(27, 519);
            this.txtNotification.Multiline = true;
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(492, 33);
            this.txtNotification.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(564, 533);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(878, 565);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNetStat);
            this.Controls.Add(this.txtNotification);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.RPanel);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.LPanel);
            this.Controls.Add(this.txtIPAddress);
            this.Name = "MainForm";
            this.Text = "GoggleConnectHDZ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LPanel.ResumeLayout(false);
            this.LPanel.PerformLayout();
            this.RPanel.ResumeLayout(false);
            this.RPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LPanel;
        private System.Windows.Forms.Panel RPanel;
        private System.Windows.Forms.TableLayoutPanel tblMovieList;
        private System.Windows.Forms.MaskedTextBox txtIPAddress;
        private Label lblIPAddress;
        private Button btnConnect;
        private Label lblUser;
        private TextBox txtUser;
        private MaskedTextBox txtPassword;
        private Label lblPassword;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtSavePath;
        private Label lblSavePath;
        private Button btnSave;
        private Label lblNetStat;
        private TextBox txtNotification;
        private TextBox textBox1;
    }
}

