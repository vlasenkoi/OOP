namespace lab16
{
    partial class Settings
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxLocalPort = new System.Windows.Forms.TextBox();
            this.textBoxRemotePort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.buttonFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(290, 321);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(153, 91);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(169, 29);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(100, 22);
            this.textBoxHost.TabIndex = 1;
            // 
            // textBoxLocalPort
            // 
            this.textBoxLocalPort.Location = new System.Drawing.Point(169, 93);
            this.textBoxLocalPort.Name = "textBoxLocalPort";
            this.textBoxLocalPort.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocalPort.TabIndex = 2;
            // 
            // textBoxRemotePort
            // 
            this.textBoxRemotePort.Location = new System.Drawing.Point(169, 164);
            this.textBoxRemotePort.Name = "textBoxRemotePort";
            this.textBoxRemotePort.Size = new System.Drawing.Size(100, 22);
            this.textBoxRemotePort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Local port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remote port";
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(412, 79);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(153, 36);
            this.buttonFont.TabIndex = 7;
            this.buttonFont.Text = "Шрифт";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRemotePort);
            this.Controls.Add(this.textBoxLocalPort);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.buttonOK);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxLocalPort;
        private System.Windows.Forms.TextBox textBoxRemotePort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button buttonFont;
    }
}