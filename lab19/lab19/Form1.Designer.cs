namespace lab19
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CPU = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listBoxCPU = new System.Windows.Forms.ListBox();
            this.listBoxVideo = new System.Windows.Forms.ListBox();
            this.listBoxDVD = new System.Windows.Forms.ListBox();
            this.listBoxDisk = new System.Windows.Forms.ListBox();
            this.listBoxMB = new System.Windows.Forms.ListBox();
            this.listBoxNetwork = new System.Windows.Forms.ListBox();
            this.listBoxBIOS = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.CPU.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CPU);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // CPU
            // 
            this.CPU.Controls.Add(this.listBoxCPU);
            this.CPU.Location = new System.Drawing.Point(4, 25);
            this.CPU.Name = "CPU";
            this.CPU.Padding = new System.Windows.Forms.Padding(3);
            this.CPU.Size = new System.Drawing.Size(880, 564);
            this.CPU.TabIndex = 0;
            this.CPU.Text = "CPU";
            this.CPU.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxVideo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxDVD);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(880, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DVD";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxDisk);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(880, 564);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DISK";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listBoxMB);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(880, 564);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "MB";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxNetwork);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 564);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Network";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listBoxBIOS);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(880, 564);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "BIOS";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listBoxCPU
            // 
            this.listBoxCPU.FormattingEnabled = true;
            this.listBoxCPU.ItemHeight = 16;
            this.listBoxCPU.Location = new System.Drawing.Point(6, 6);
            this.listBoxCPU.Name = "listBoxCPU";
            this.listBoxCPU.Size = new System.Drawing.Size(859, 548);
            this.listBoxCPU.TabIndex = 0;
            // 
            // listBoxVideo
            // 
            this.listBoxVideo.FormattingEnabled = true;
            this.listBoxVideo.ItemHeight = 16;
            this.listBoxVideo.Location = new System.Drawing.Point(11, 8);
            this.listBoxVideo.Name = "listBoxVideo";
            this.listBoxVideo.Size = new System.Drawing.Size(859, 548);
            this.listBoxVideo.TabIndex = 1;
            // 
            // listBoxDVD
            // 
            this.listBoxDVD.FormattingEnabled = true;
            this.listBoxDVD.ItemHeight = 16;
            this.listBoxDVD.Location = new System.Drawing.Point(11, 8);
            this.listBoxDVD.Name = "listBoxDVD";
            this.listBoxDVD.Size = new System.Drawing.Size(859, 548);
            this.listBoxDVD.TabIndex = 1;
            // 
            // listBoxDisk
            // 
            this.listBoxDisk.FormattingEnabled = true;
            this.listBoxDisk.ItemHeight = 16;
            this.listBoxDisk.Location = new System.Drawing.Point(11, 8);
            this.listBoxDisk.Name = "listBoxDisk";
            this.listBoxDisk.Size = new System.Drawing.Size(859, 548);
            this.listBoxDisk.TabIndex = 1;
            // 
            // listBoxMB
            // 
            this.listBoxMB.FormattingEnabled = true;
            this.listBoxMB.ItemHeight = 16;
            this.listBoxMB.Location = new System.Drawing.Point(11, 8);
            this.listBoxMB.Name = "listBoxMB";
            this.listBoxMB.Size = new System.Drawing.Size(859, 548);
            this.listBoxMB.TabIndex = 1;
            // 
            // listBoxNetwork
            // 
            this.listBoxNetwork.FormattingEnabled = true;
            this.listBoxNetwork.ItemHeight = 16;
            this.listBoxNetwork.Location = new System.Drawing.Point(11, 8);
            this.listBoxNetwork.Name = "listBoxNetwork";
            this.listBoxNetwork.Size = new System.Drawing.Size(859, 548);
            this.listBoxNetwork.TabIndex = 1;
            // 
            // listBoxBIOS
            // 
            this.listBoxBIOS.FormattingEnabled = true;
            this.listBoxBIOS.ItemHeight = 16;
            this.listBoxBIOS.Location = new System.Drawing.Point(11, 8);
            this.listBoxBIOS.Name = "listBoxBIOS";
            this.listBoxBIOS.Size = new System.Drawing.Size(859, 548);
            this.listBoxBIOS.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 592);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.CPU.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CPU;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox listBoxCPU;
        private System.Windows.Forms.ListBox listBoxVideo;
        private System.Windows.Forms.ListBox listBoxDVD;
        private System.Windows.Forms.ListBox listBoxDisk;
        private System.Windows.Forms.ListBox listBoxMB;
        private System.Windows.Forms.ListBox listBoxNetwork;
        private System.Windows.Forms.ListBox listBoxBIOS;
    }
}

