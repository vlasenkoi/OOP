namespace lab2
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
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.v1TxtX = new System.Windows.Forms.TextBox();
            this.v2TxtX = new System.Windows.Forms.TextBox();
            this.v1TxtY = new System.Windows.Forms.TextBox();
            this.v2TxtY = new System.Windows.Forms.TextBox();
            this.v1TxtZ = new System.Windows.Forms.TextBox();
            this.v2TxtZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(442, 32);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(359, 356);
            this.lbOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vertor1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vector2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Z";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(152, 233);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 36);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // v1TxtX
            // 
            this.v1TxtX.Location = new System.Drawing.Point(86, 62);
            this.v1TxtX.Name = "v1TxtX";
            this.v1TxtX.Size = new System.Drawing.Size(87, 22);
            this.v1TxtX.TabIndex = 7;
            this.v1TxtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v1TxtX_KeyPress);
            // 
            // v2TxtX
            // 
            this.v2TxtX.Location = new System.Drawing.Point(241, 62);
            this.v2TxtX.Name = "v2TxtX";
            this.v2TxtX.Size = new System.Drawing.Size(87, 22);
            this.v2TxtX.TabIndex = 8;
            this.v2TxtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v2TxtX_KeyPress);
            // 
            // v1TxtY
            // 
            this.v1TxtY.Location = new System.Drawing.Point(86, 106);
            this.v1TxtY.Name = "v1TxtY";
            this.v1TxtY.Size = new System.Drawing.Size(87, 22);
            this.v1TxtY.TabIndex = 9;
            this.v1TxtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v1TxtY_KeyPress);
            // 
            // v2TxtY
            // 
            this.v2TxtY.Location = new System.Drawing.Point(241, 106);
            this.v2TxtY.Name = "v2TxtY";
            this.v2TxtY.Size = new System.Drawing.Size(87, 22);
            this.v2TxtY.TabIndex = 10;
            this.v2TxtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v2TxtY_KeyPress);
            // 
            // v1TxtZ
            // 
            this.v1TxtZ.Location = new System.Drawing.Point(86, 146);
            this.v1TxtZ.Name = "v1TxtZ";
            this.v1TxtZ.Size = new System.Drawing.Size(87, 22);
            this.v1TxtZ.TabIndex = 11;
            this.v1TxtZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v1TxtZ_KeyPress);
            // 
            // v2TxtZ
            // 
            this.v2TxtZ.Location = new System.Drawing.Point(241, 146);
            this.v2TxtZ.Name = "v2TxtZ";
            this.v2TxtZ.Size = new System.Drawing.Size(87, 22);
            this.v2TxtZ.TabIndex = 12;
            this.v2TxtZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v2TxtZ_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 484);
            this.Controls.Add(this.v2TxtZ);
            this.Controls.Add(this.v1TxtZ);
            this.Controls.Add(this.v2TxtY);
            this.Controls.Add(this.v1TxtY);
            this.Controls.Add(this.v2TxtX);
            this.Controls.Add(this.v1TxtX);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox v1TxtX;
        private System.Windows.Forms.TextBox v2TxtX;
        private System.Windows.Forms.TextBox v1TxtY;
        private System.Windows.Forms.TextBox v2TxtY;
        private System.Windows.Forms.TextBox v1TxtZ;
        private System.Windows.Forms.TextBox v2TxtZ;
    }
}

