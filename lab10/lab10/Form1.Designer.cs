namespace lab10
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.t1BtnStopThreadAll = new System.Windows.Forms.Button();
            this.t1BtnStartThreadAll = new System.Windows.Forms.Button();
            this.t1BtnStopThread3 = new System.Windows.Forms.Button();
            this.t1BtnStartThread3 = new System.Windows.Forms.Button();
            this.t1BtnStopThread2 = new System.Windows.Forms.Button();
            this.t1BtnStartThread2 = new System.Windows.Forms.Button();
            this.t1BtnStopThread1 = new System.Windows.Forms.Button();
            this.t1BtnStartThread1 = new System.Windows.Forms.Button();
            this.rTxtThread3 = new System.Windows.Forms.RichTextBox();
            this.panelThread2 = new System.Windows.Forms.Panel();
            this.panelThread1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMesFEAL = new System.Windows.Forms.TextBox();
            this.t1BtnFEAL = new System.Windows.Forms.Button();
            this.lblDecFEAL = new System.Windows.Forms.Label();
            this.lblEncFEAL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEncMD2 = new System.Windows.Forms.Label();
            this.txtMesMD2 = new System.Windows.Forms.TextBox();
            this.btnMD2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEncMcelience = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDecMcelience = new System.Windows.Forms.Label();
            this.txtMesMcelience = new System.Windows.Forms.TextBox();
            this.btnMcelience = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1116, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.t1BtnStopThreadAll);
            this.tabPage1.Controls.Add(this.t1BtnStartThreadAll);
            this.tabPage1.Controls.Add(this.t1BtnStopThread3);
            this.tabPage1.Controls.Add(this.t1BtnStartThread3);
            this.tabPage1.Controls.Add(this.t1BtnStopThread2);
            this.tabPage1.Controls.Add(this.t1BtnStartThread2);
            this.tabPage1.Controls.Add(this.t1BtnStopThread1);
            this.tabPage1.Controls.Add(this.t1BtnStartThread1);
            this.tabPage1.Controls.Add(this.rTxtThread3);
            this.tabPage1.Controls.Add(this.panelThread2);
            this.tabPage1.Controls.Add(this.panelThread1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1108, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // t1BtnStopThreadAll
            // 
            this.t1BtnStopThreadAll.Location = new System.Drawing.Point(33, 448);
            this.t1BtnStopThreadAll.Name = "t1BtnStopThreadAll";
            this.t1BtnStopThreadAll.Size = new System.Drawing.Size(1003, 29);
            this.t1BtnStopThreadAll.TabIndex = 10;
            this.t1BtnStopThreadAll.Text = "Зупинити всі потоки";
            this.t1BtnStopThreadAll.UseVisualStyleBackColor = true;
            this.t1BtnStopThreadAll.Click += new System.EventHandler(this.t1BtnStopThreadAll_Click);
            // 
            // t1BtnStartThreadAll
            // 
            this.t1BtnStartThreadAll.Location = new System.Drawing.Point(30, 401);
            this.t1BtnStartThreadAll.Name = "t1BtnStartThreadAll";
            this.t1BtnStartThreadAll.Size = new System.Drawing.Size(1006, 27);
            this.t1BtnStartThreadAll.TabIndex = 9;
            this.t1BtnStartThreadAll.Text = "Запустити всі потоки";
            this.t1BtnStartThreadAll.UseVisualStyleBackColor = true;
            this.t1BtnStartThreadAll.Click += new System.EventHandler(this.t1BtnStartThreadAll_Click);
            // 
            // t1BtnStopThread3
            // 
            this.t1BtnStopThread3.Location = new System.Drawing.Point(710, 356);
            this.t1BtnStopThread3.Name = "t1BtnStopThread3";
            this.t1BtnStopThread3.Size = new System.Drawing.Size(326, 24);
            this.t1BtnStopThread3.TabIndex = 8;
            this.t1BtnStopThread3.Text = "Зупинити потік";
            this.t1BtnStopThread3.UseVisualStyleBackColor = true;
            this.t1BtnStopThread3.Click += new System.EventHandler(this.t1BtnStopThread3_Click);
            // 
            // t1BtnStartThread3
            // 
            this.t1BtnStartThread3.Location = new System.Drawing.Point(715, 308);
            this.t1BtnStartThread3.Name = "t1BtnStartThread3";
            this.t1BtnStartThread3.Size = new System.Drawing.Size(322, 26);
            this.t1BtnStartThread3.TabIndex = 7;
            this.t1BtnStartThread3.Text = "Запустити 3 потік";
            this.t1BtnStartThread3.UseVisualStyleBackColor = true;
            this.t1BtnStartThread3.Click += new System.EventHandler(this.t1BtnStartThread3_Click);
            // 
            // t1BtnStopThread2
            // 
            this.t1BtnStopThread2.Location = new System.Drawing.Point(345, 356);
            this.t1BtnStopThread2.Name = "t1BtnStopThread2";
            this.t1BtnStopThread2.Size = new System.Drawing.Size(270, 24);
            this.t1BtnStopThread2.TabIndex = 6;
            this.t1BtnStopThread2.Text = "Зупинити потік";
            this.t1BtnStopThread2.UseVisualStyleBackColor = true;
            this.t1BtnStopThread2.Click += new System.EventHandler(this.t1BtnStopThread2_Click);
            // 
            // t1BtnStartThread2
            // 
            this.t1BtnStartThread2.Location = new System.Drawing.Point(348, 311);
            this.t1BtnStartThread2.Name = "t1BtnStartThread2";
            this.t1BtnStartThread2.Size = new System.Drawing.Size(268, 23);
            this.t1BtnStartThread2.TabIndex = 5;
            this.t1BtnStartThread2.Text = "Запустити 2 потік";
            this.t1BtnStartThread2.UseVisualStyleBackColor = true;
            this.t1BtnStartThread2.Click += new System.EventHandler(this.t1BtnStartThread2_Click);
            // 
            // t1BtnStopThread1
            // 
            this.t1BtnStopThread1.Location = new System.Drawing.Point(30, 356);
            this.t1BtnStopThread1.Name = "t1BtnStopThread1";
            this.t1BtnStopThread1.Size = new System.Drawing.Size(248, 25);
            this.t1BtnStopThread1.TabIndex = 4;
            this.t1BtnStopThread1.Text = "Зупинити потік";
            this.t1BtnStopThread1.UseVisualStyleBackColor = true;
            this.t1BtnStopThread1.Click += new System.EventHandler(this.t1BtnStopThread1_Click);
            // 
            // t1BtnStartThread1
            // 
            this.t1BtnStartThread1.Location = new System.Drawing.Point(35, 308);
            this.t1BtnStartThread1.Name = "t1BtnStartThread1";
            this.t1BtnStartThread1.Size = new System.Drawing.Size(243, 27);
            this.t1BtnStartThread1.TabIndex = 3;
            this.t1BtnStartThread1.Text = "Запустити 1 потік";
            this.t1BtnStartThread1.UseVisualStyleBackColor = true;
            this.t1BtnStartThread1.Click += new System.EventHandler(this.t1BtnStartThread1_Click);
            // 
            // rTxtThread3
            // 
            this.rTxtThread3.Location = new System.Drawing.Point(714, 32);
            this.rTxtThread3.Name = "rTxtThread3";
            this.rTxtThread3.Size = new System.Drawing.Size(323, 257);
            this.rTxtThread3.TabIndex = 2;
            this.rTxtThread3.Text = "";
            // 
            // panelThread2
            // 
            this.panelThread2.Location = new System.Drawing.Point(351, 30);
            this.panelThread2.Name = "panelThread2";
            this.panelThread2.Size = new System.Drawing.Size(266, 259);
            this.panelThread2.TabIndex = 1;
            // 
            // panelThread1
            // 
            this.panelThread1.Location = new System.Drawing.Point(31, 29);
            this.panelThread1.Name = "panelThread1";
            this.panelThread1.Size = new System.Drawing.Size(248, 261);
            this.panelThread1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMcelience);
            this.tabPage2.Controls.Add(this.txtMesMcelience);
            this.tabPage2.Controls.Add(this.lblDecMcelience);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lblEncMcelience);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnMD2);
            this.tabPage2.Controls.Add(this.txtMesMD2);
            this.tabPage2.Controls.Add(this.lblEncMD2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtMesFEAL);
            this.tabPage2.Controls.Add(this.t1BtnFEAL);
            this.tabPage2.Controls.Add(this.lblDecFEAL);
            this.tabPage2.Controls.Add(this.lblEncFEAL);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1108, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMesFEAL
            // 
            this.txtMesFEAL.Location = new System.Drawing.Point(124, 85);
            this.txtMesFEAL.Name = "txtMesFEAL";
            this.txtMesFEAL.Size = new System.Drawing.Size(163, 22);
            this.txtMesFEAL.TabIndex = 9;
            this.txtMesFEAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesFEAL_KeyPress);
            // 
            // t1BtnFEAL
            // 
            this.t1BtnFEAL.Location = new System.Drawing.Point(19, 323);
            this.t1BtnFEAL.Name = "t1BtnFEAL";
            this.t1BtnFEAL.Size = new System.Drawing.Size(191, 41);
            this.t1BtnFEAL.TabIndex = 8;
            this.t1BtnFEAL.Text = "Запустити";
            this.t1BtnFEAL.UseVisualStyleBackColor = true;
            this.t1BtnFEAL.Click += new System.EventHandler(this.t1BtnFEAL_Click);
            // 
            // lblDecFEAL
            // 
            this.lblDecFEAL.AutoSize = true;
            this.lblDecFEAL.Location = new System.Drawing.Point(30, 271);
            this.lblDecFEAL.Name = "lblDecFEAL";
            this.lblDecFEAL.Size = new System.Drawing.Size(0, 16);
            this.lblDecFEAL.TabIndex = 7;
            // 
            // lblEncFEAL
            // 
            this.lblEncFEAL.AutoSize = true;
            this.lblEncFEAL.Location = new System.Drawing.Point(30, 183);
            this.lblEncFEAL.Name = "lblEncFEAL";
            this.lblEncFEAL.Size = new System.Drawing.Size(0, 16);
            this.lblEncFEAL.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Розшифроване повідомлення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Зашифроване повідомлення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Повідомлення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mceliece";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MD-2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FEAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Повідомлення";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Зашифроване повідомлення";
            // 
            // lblEncMD2
            // 
            this.lblEncMD2.AutoSize = true;
            this.lblEncMD2.Location = new System.Drawing.Point(403, 183);
            this.lblEncMD2.Name = "lblEncMD2";
            this.lblEncMD2.Size = new System.Drawing.Size(0, 20);
            this.lblEncMD2.TabIndex = 13;
            // 
            // txtMesMD2
            // 
            this.txtMesMD2.Location = new System.Drawing.Point(513, 90);
            this.txtMesMD2.Name = "txtMesMD2";
            this.txtMesMD2.Size = new System.Drawing.Size(165, 22);
            this.txtMesMD2.TabIndex = 15;
            this.txtMesMD2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesMD2_KeyPress);
            // 
            // btnMD2
            // 
            this.btnMD2.Location = new System.Drawing.Point(426, 324);
            this.btnMD2.Name = "btnMD2";
            this.btnMD2.Size = new System.Drawing.Size(225, 39);
            this.btnMD2.TabIndex = 16;
            this.btnMD2.Text = "Запустити";
            this.btnMD2.UseVisualStyleBackColor = true;
            this.btnMD2.Click += new System.EventHandler(this.btnMD2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(800, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Повідомлення";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(800, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Зашифроване повідомлення";
            // 
            // lblEncMcelience
            // 
            this.lblEncMcelience.AutoSize = true;
            this.lblEncMcelience.Location = new System.Drawing.Point(800, 178);
            this.lblEncMcelience.Name = "lblEncMcelience";
            this.lblEncMcelience.Size = new System.Drawing.Size(0, 20);
            this.lblEncMcelience.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(800, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Дешифроване повідомлення";
            // 
            // lblDecMcelience
            // 
            this.lblDecMcelience.AutoSize = true;
            this.lblDecMcelience.Location = new System.Drawing.Point(800, 271);
            this.lblDecMcelience.Name = "lblDecMcelience";
            this.lblDecMcelience.Size = new System.Drawing.Size(0, 20);
            this.lblDecMcelience.TabIndex = 21;
            // 
            // txtMesMcelience
            // 
            this.txtMesMcelience.Location = new System.Drawing.Point(909, 96);
            this.txtMesMcelience.Name = "txtMesMcelience";
            this.txtMesMcelience.Size = new System.Drawing.Size(163, 22);
            this.txtMesMcelience.TabIndex = 22;
            this.txtMesMcelience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesMcelience_KeyPress);
            // 
            // btnMcelience
            // 
            this.btnMcelience.Location = new System.Drawing.Point(840, 330);
            this.btnMcelience.Name = "btnMcelience";
            this.btnMcelience.Size = new System.Drawing.Size(189, 32);
            this.btnMcelience.TabIndex = 23;
            this.btnMcelience.Text = "Запустити";
            this.btnMcelience.UseVisualStyleBackColor = true;
            this.btnMcelience.Click += new System.EventHandler(this.btnMcelience_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button t1BtnStopThreadAll;
        private System.Windows.Forms.Button t1BtnStartThreadAll;
        private System.Windows.Forms.Button t1BtnStopThread3;
        private System.Windows.Forms.Button t1BtnStartThread3;
        private System.Windows.Forms.Button t1BtnStopThread2;
        private System.Windows.Forms.Button t1BtnStartThread2;
        private System.Windows.Forms.Button t1BtnStopThread1;
        private System.Windows.Forms.Button t1BtnStartThread1;
        private System.Windows.Forms.RichTextBox rTxtThread3;
        private System.Windows.Forms.Panel panelThread2;
        private System.Windows.Forms.Panel panelThread1;
        private System.Windows.Forms.TextBox txtMesFEAL;
        private System.Windows.Forms.Button t1BtnFEAL;
        private System.Windows.Forms.Label lblDecFEAL;
        private System.Windows.Forms.Label lblEncFEAL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMD2;
        private System.Windows.Forms.TextBox txtMesMD2;
        private System.Windows.Forms.Label lblEncMD2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMcelience;
        private System.Windows.Forms.TextBox txtMesMcelience;
        private System.Windows.Forms.Label lblDecMcelience;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEncMcelience;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

