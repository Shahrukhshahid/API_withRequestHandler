namespace Downloads
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_select = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_txtfilename = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtdestinationfolder = new System.Windows.Forms.TextBox();
            this.txtSourceFileName = new System.Windows.Forms.TextBox();
            this.lbDestination = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_downloadedCount = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.lb_remaining = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_totalCount = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_select.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(473, 151);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(100, 28);
            this.btn_select.TabIndex = 8;
            this.btn_select.Text = "Select ";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.Btn_dwnld_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(9, 610);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 43);
            this.panel3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "© 2019-2022 Copyrights D4Done ";
            // 
            // lb_txtfilename
            // 
            this.lb_txtfilename.AutoSize = true;
            this.lb_txtfilename.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txtfilename.Location = new System.Drawing.Point(27, 70);
            this.lb_txtfilename.Name = "lb_txtfilename";
            this.lb_txtfilename.Size = new System.Drawing.Size(121, 23);
            this.lb_txtfilename.TabIndex = 3;
            this.lb_txtfilename.Text = "Source File Name";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(342, 121);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(0, 23);
            this.lbFileName.TabIndex = 15;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lb_error);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtdestinationfolder);
            this.panel2.Controls.Add(this.txtSourceFileName);
            this.panel2.Controls.Add(this.lbDestination);
            this.panel2.Controls.Add(this.btn_select);
            this.panel2.Controls.Add(this.lb_txtfilename);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(19, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 323);
            this.panel2.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 17;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(199, 125);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 23);
            this.lb_error.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdestinationfolder
            // 
            this.txtdestinationfolder.BackColor = System.Drawing.Color.White;
            this.txtdestinationfolder.Cursor = System.Windows.Forms.Cursors.No;
            this.txtdestinationfolder.Location = new System.Drawing.Point(179, 151);
            this.txtdestinationfolder.Name = "txtdestinationfolder";
            this.txtdestinationfolder.ReadOnly = true;
            this.txtdestinationfolder.Size = new System.Drawing.Size(249, 28);
            this.txtdestinationfolder.TabIndex = 10;
            // 
            // txtSourceFileName
            // 
            this.txtSourceFileName.BackColor = System.Drawing.Color.White;
            this.txtSourceFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSourceFileName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSourceFileName.HideSelection = false;
            this.txtSourceFileName.Location = new System.Drawing.Point(179, 68);
            this.txtSourceFileName.Name = "txtSourceFileName";
            this.txtSourceFileName.ReadOnly = true;
            this.txtSourceFileName.Size = new System.Drawing.Size(249, 28);
            this.txtSourceFileName.TabIndex = 9;
            this.txtSourceFileName.TextChanged += new System.EventHandler(this.txtSourceFileName_TextChanged);
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDestination.Location = new System.Drawing.Point(27, 151);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(127, 23);
            this.lbDestination.TabIndex = 11;
            this.lbDestination.Text = "Destination Folder";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 658);
            this.panel4.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 589);
            this.panel1.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lb_downloadedCount);
            this.panel5.Controls.Add(this.resultLabel);
            this.panel5.Controls.Add(this.lb_remaining);
            this.panel5.Controls.Add(this.progressBar1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lb_total);
            this.panel5.Controls.Add(this.lb_totalCount);
            this.panel5.Location = new System.Drawing.Point(19, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 216);
            this.panel5.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Progress :";
            // 
            // lb_downloadedCount
            // 
            this.lb_downloadedCount.AutoSize = true;
            this.lb_downloadedCount.Location = new System.Drawing.Point(434, 175);
            this.lb_downloadedCount.Name = "lb_downloadedCount";
            this.lb_downloadedCount.Size = new System.Drawing.Size(18, 23);
            this.lb_downloadedCount.TabIndex = 20;
            this.lb_downloadedCount.Text = "0";
            this.lb_downloadedCount.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(492, 84);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 23);
            this.resultLabel.TabIndex = 16;
            // 
            // lb_remaining
            // 
            this.lb_remaining.AutoSize = true;
            this.lb_remaining.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_remaining.Location = new System.Drawing.Point(53, 84);
            this.lb_remaining.Name = "lb_remaining";
            this.lb_remaining.Size = new System.Drawing.Size(102, 23);
            this.lb_remaining.TabIndex = 13;
            this.lb_remaining.Text = "Downloading :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(169, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Downloaded  : ";
            this.label2.Visible = false;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(237, 136);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(108, 23);
            this.lb_total.TabIndex = 11;
            this.lb_total.Text = "Total Records : ";
            // 
            // lb_totalCount
            // 
            this.lb_totalCount.AutoSize = true;
            this.lb_totalCount.Location = new System.Drawing.Point(348, 135);
            this.lb_totalCount.Name = "lb_totalCount";
            this.lb_totalCount.Size = new System.Drawing.Size(18, 23);
            this.lb_totalCount.TabIndex = 12;
            this.lb_totalCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(670, 664);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbFileName);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "D4Done Downloader";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_txtfilename;
        private System.Windows.Forms.Label lbFileName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.TextBox txtdestinationfolder;
        private System.Windows.Forms.TextBox txtSourceFileName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_remaining;
        private System.Windows.Forms.Label lb_totalCount;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb_downloadedCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
    }
}

