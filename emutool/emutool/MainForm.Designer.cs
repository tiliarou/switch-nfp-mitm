﻿namespace emutool
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AmiiboNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RandomizeUuidCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UseNameCheck = new System.Windows.Forms.CheckBox();
            this.DirectoryNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveImageCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LastPathCheck = new System.Windows.Forms.CheckBox();
            this.LastPathLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FtpPortBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FtpSaveCheck = new System.Windows.Forms.CheckBox();
            this.FtpAddressBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AmiiboPictureBox = new System.Windows.Forms.PictureBox();
            this.SeriesComboBox = new System.Windows.Forms.ComboBox();
            this.AmiiboComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmiiboPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AmiiboNameBox
            // 
            this.AmiiboNameBox.Location = new System.Drawing.Point(18, 42);
            this.AmiiboNameBox.MaxLength = 10;
            this.AmiiboNameBox.Name = "AmiiboNameBox";
            this.AmiiboNameBox.Size = new System.Drawing.Size(361, 20);
            this.AmiiboNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // RandomizeUuidCheck
            // 
            this.RandomizeUuidCheck.AutoSize = true;
            this.RandomizeUuidCheck.Location = new System.Drawing.Point(18, 246);
            this.RandomizeUuidCheck.Name = "RandomizeUuidCheck";
            this.RandomizeUuidCheck.Size = new System.Drawing.Size(168, 17);
            this.RandomizeUuidCheck.TabIndex = 4;
            this.RandomizeUuidCheck.Text = "Randomize UUID in emulation";
            this.RandomizeUuidCheck.UseVisualStyleBackColor = true;
            this.RandomizeUuidCheck.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 65);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UseNameCheck);
            this.groupBox2.Controls.Add(this.DirectoryNameBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SaveImageCheck);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AmiiboNameBox);
            this.groupBox2.Controls.Add(this.RandomizeUuidCheck);
            this.groupBox2.Location = new System.Drawing.Point(418, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 351);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2 - Customize the virtual amiibo";
            // 
            // UseNameCheck
            // 
            this.UseNameCheck.AutoSize = true;
            this.UseNameCheck.Checked = true;
            this.UseNameCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseNameCheck.Location = new System.Drawing.Point(18, 127);
            this.UseNameCheck.Name = "UseNameCheck";
            this.UseNameCheck.Size = new System.Drawing.Size(160, 17);
            this.UseNameCheck.TabIndex = 10;
            this.UseNameCheck.Text = "Use name as directory name";
            this.UseNameCheck.UseVisualStyleBackColor = true;
            this.UseNameCheck.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // DirectoryNameBox
            // 
            this.DirectoryNameBox.Enabled = false;
            this.DirectoryNameBox.Location = new System.Drawing.Point(18, 89);
            this.DirectoryNameBox.MaxLength = 10;
            this.DirectoryNameBox.Name = "DirectoryNameBox";
            this.DirectoryNameBox.Size = new System.Drawing.Size(361, 20);
            this.DirectoryNameBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Directory name:";
            // 
            // SaveImageCheck
            // 
            this.SaveImageCheck.AutoSize = true;
            this.SaveImageCheck.Location = new System.Drawing.Point(18, 304);
            this.SaveImageCheck.Name = "SaveImageCheck";
            this.SaveImageCheck.Size = new System.Drawing.Size(115, 17);
            this.SaveImageCheck.TabIndex = 7;
            this.SaveImageCheck.Text = "Save amiibo image\r\n";
            this.SaveImageCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Save the amiibo\'s image along with the amiibo.";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(18, 163);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(361, 34);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create virtual amiibo";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(60, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "In console, emuiibo will generate a random mii for the amiibo.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LastPathCheck);
            this.groupBox3.Controls.Add(this.LastPathLabel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.FtpPortBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.FtpSaveCheck);
            this.groupBox3.Controls.Add(this.CreateButton);
            this.groupBox3.Controls.Add(this.FtpAddressBox);
            this.groupBox3.Location = new System.Drawing.Point(418, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 214);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3 - Generate the virtual amiibo";
            // 
            // LastPathCheck
            // 
            this.LastPathCheck.AutoSize = true;
            this.LastPathCheck.Checked = true;
            this.LastPathCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastPathCheck.Location = new System.Drawing.Point(31, 136);
            this.LastPathCheck.Name = "LastPathCheck";
            this.LastPathCheck.Size = new System.Drawing.Size(155, 17);
            this.LastPathCheck.TabIndex = 17;
            this.LastPathCheck.Text = "Create in the last used path\n";
            this.LastPathCheck.UseVisualStyleBackColor = true;
            this.LastPathCheck.Visible = false;
            // 
            // LastPathLabel
            // 
            this.LastPathLabel.AutoSize = true;
            this.LastPathLabel.BackColor = System.Drawing.SystemColors.Control;
            this.LastPathLabel.ForeColor = System.Drawing.Color.DimGray;
            this.LastPathLabel.Location = new System.Drawing.Point(28, 110);
            this.LastPathLabel.Name = "LastPathLabel";
            this.LastPathLabel.Size = new System.Drawing.Size(42, 13);
            this.LastPathLabel.TabIndex = 16;
            this.LastPathLabel.Text = "Dummy";
            this.LastPathLabel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "ftp://";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Port:";
            // 
            // FtpPortBox
            // 
            this.FtpPortBox.Enabled = false;
            this.FtpPortBox.Location = new System.Drawing.Point(293, 67);
            this.FtpPortBox.Name = "FtpPortBox";
            this.FtpPortBox.Size = new System.Drawing.Size(83, 20);
            this.FtpPortBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address:";
            // 
            // FtpSaveCheck
            // 
            this.FtpSaveCheck.AutoSize = true;
            this.FtpSaveCheck.Location = new System.Drawing.Point(18, 26);
            this.FtpSaveCheck.Name = "FtpSaveCheck";
            this.FtpSaveCheck.Size = new System.Drawing.Size(86, 17);
            this.FtpSaveCheck.TabIndex = 11;
            this.FtpSaveCheck.Text = "Save to FTP";
            this.FtpSaveCheck.UseVisualStyleBackColor = true;
            this.FtpSaveCheck.CheckedChanged += new System.EventHandler(this.chkFTP_CheckedChanged);
            // 
            // FtpAddressBox
            // 
            this.FtpAddressBox.Enabled = false;
            this.FtpAddressBox.Location = new System.Drawing.Point(49, 67);
            this.FtpAddressBox.Name = "FtpAddressBox";
            this.FtpAddressBox.Size = new System.Drawing.Size(221, 20);
            this.FtpAddressBox.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(776, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::emutool.Properties.Resources.OkIcon;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "    ";
            this.toolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // AmiiboPictureBox
            // 
            this.AmiiboPictureBox.Location = new System.Drawing.Point(17, 60);
            this.AmiiboPictureBox.Name = "AmiiboPictureBox";
            this.AmiiboPictureBox.Size = new System.Drawing.Size(362, 434);
            this.AmiiboPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AmiiboPictureBox.TabIndex = 0;
            this.AmiiboPictureBox.TabStop = false;
            // 
            // SeriesComboBox
            // 
            this.SeriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeriesComboBox.FormattingEnabled = true;
            this.SeriesComboBox.Location = new System.Drawing.Point(17, 26);
            this.SeriesComboBox.Name = "SeriesComboBox";
            this.SeriesComboBox.Size = new System.Drawing.Size(177, 21);
            this.SeriesComboBox.TabIndex = 1;
            this.SeriesComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // AmiiboComboBox
            // 
            this.AmiiboComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmiiboComboBox.FormattingEnabled = true;
            this.AmiiboComboBox.Location = new System.Drawing.Point(202, 26);
            this.AmiiboComboBox.Name = "AmiiboComboBox";
            this.AmiiboComboBox.Size = new System.Drawing.Size(177, 21);
            this.AmiiboComboBox.TabIndex = 2;
            this.AmiiboComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AmiiboComboBox);
            this.groupBox1.Controls.Add(this.SeriesComboBox);
            this.groupBox1.Controls.Add(this.AmiiboPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 510);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 - Choose a virtual amiibo";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(29, 532);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(362, 28);
            this.AboutButton.TabIndex = 12;
            this.AboutButton.Text = "About emuiibo and emutool";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 615);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dummy";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmiiboPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AmiiboNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RandomizeUuidCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox UseNameCheck;
        private System.Windows.Forms.TextBox DirectoryNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox SaveImageCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox AmiiboPictureBox;
        private System.Windows.Forms.ComboBox SeriesComboBox;
        private System.Windows.Forms.ComboBox AmiiboComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox FtpSaveCheck;
        private System.Windows.Forms.TextBox FtpAddressBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FtpPortBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label LastPathLabel;
        private System.Windows.Forms.CheckBox LastPathCheck;
    }
}

