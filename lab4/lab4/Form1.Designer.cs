namespace lab4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.t1TxtArr = new System.Windows.Forms.TextBox();
            this.t1BtnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.t2TxtR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t2TxtC = new System.Windows.Forms.TextBox();
            this.t2lbOutput = new System.Windows.Forms.ListBox();
            this.t2BtnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.t2TxtS = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.t1BtnOK);
            this.tabPage1.Controls.Add(this.t1TxtArr);
            this.tabPage1.Controls.Add(this.lbOutput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.t2TxtS);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.t2BtnOK);
            this.tabPage2.Controls.Add(this.t2lbOutput);
            this.tabPage2.Controls.Add(this.t2TxtC);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.t2TxtR);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть масив";
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(336, 234);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(306, 164);
            this.lbOutput.TabIndex = 2;
            // 
            // t1TxtArr
            // 
            this.t1TxtArr.Location = new System.Drawing.Point(120, 227);
            this.t1TxtArr.Name = "t1TxtArr";
            this.t1TxtArr.Size = new System.Drawing.Size(169, 22);
            this.t1TxtArr.TabIndex = 3;
            this.t1TxtArr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t1TxtArr_KeyPress);
            // 
            // t1BtnOK
            // 
            this.t1BtnOK.Location = new System.Drawing.Point(125, 319);
            this.t1BtnOK.Name = "t1BtnOK";
            this.t1BtnOK.Size = new System.Drawing.Size(79, 33);
            this.t1BtnOK.TabIndex = 4;
            this.t1BtnOK.Text = "OK";
            this.t1BtnOK.UseVisualStyleBackColor = true;
            this.t1BtnOK.Click += new System.EventHandler(this.t1BtnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рядки = ";
            // 
            // t2TxtR
            // 
            this.t2TxtR.Location = new System.Drawing.Point(137, 175);
            this.t2TxtR.Name = "t2TxtR";
            this.t2TxtR.Size = new System.Drawing.Size(129, 22);
            this.t2TxtR.TabIndex = 2;
            this.t2TxtR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t2TxtR_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Стовпці = ";
            // 
            // t2TxtC
            // 
            this.t2TxtC.Location = new System.Drawing.Point(137, 238);
            this.t2TxtC.Name = "t2TxtC";
            this.t2TxtC.Size = new System.Drawing.Size(128, 22);
            this.t2TxtC.TabIndex = 4;
            this.t2TxtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t2TxtC_KeyPress);
            // 
            // t2lbOutput
            // 
            this.t2lbOutput.FormattingEnabled = true;
            this.t2lbOutput.ItemHeight = 16;
            this.t2lbOutput.Location = new System.Drawing.Point(433, 177);
            this.t2lbOutput.Name = "t2lbOutput";
            this.t2lbOutput.Size = new System.Drawing.Size(352, 260);
            this.t2lbOutput.TabIndex = 5;
            // 
            // t2BtnOK
            // 
            this.t2BtnOK.Location = new System.Drawing.Point(107, 380);
            this.t2BtnOK.Name = "t2BtnOK";
            this.t2BtnOK.Size = new System.Drawing.Size(100, 38);
            this.t2BtnOK.TabIndex = 6;
            this.t2BtnOK.Text = "OK";
            this.t2BtnOK.UseVisualStyleBackColor = true;
            this.t2BtnOK.Click += new System.EventHandler(this.t2BtnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "S =";
            // 
            // t2TxtS
            // 
            this.t2TxtS.Location = new System.Drawing.Point(137, 294);
            this.t2TxtS.Name = "t2TxtS";
            this.t2TxtS.Size = new System.Drawing.Size(128, 22);
            this.t2TxtS.TabIndex = 8;
            this.t2TxtS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t2TxtS_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button t1BtnOK;
        private System.Windows.Forms.TextBox t1TxtArr;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox t2TxtS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button t2BtnOK;
        private System.Windows.Forms.ListBox t2lbOutput;
        private System.Windows.Forms.TextBox t2TxtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t2TxtR;
        private System.Windows.Forms.Label label2;
    }
}

