namespace lab5
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(369, 55);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(442, 388);
            this.lbOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рядок: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Слово: ";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(79, 52);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(269, 66);
            this.txtString.TabIndex = 3;
            this.txtString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtString_KeyPress);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(79, 143);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(269, 22);
            this.txtWord.TabIndex = 4;
            this.txtWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWord_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(113, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 36);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 464);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtString);
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
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnOK;
    }
}

