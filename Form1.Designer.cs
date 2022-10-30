
namespace myTypeLaba3
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textSecondNum = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.textFirstNum = new System.Windows.Forms.TextBox();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Комплексные числа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textSecondNum
            // 
            this.textSecondNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSecondNum.Location = new System.Drawing.Point(12, 109);
            this.textSecondNum.Multiline = true;
            this.textSecondNum.Name = "textSecondNum";
            this.textSecondNum.Size = new System.Drawing.Size(279, 60);
            this.textSecondNum.TabIndex = 16;
            this.textSecondNum.Text = "ВТОРОЕ ЧИСЛО";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(240, 175);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(51, 40);
            this.button16.TabIndex = 17;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // textFirstNum
            // 
            this.textFirstNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFirstNum.Location = new System.Drawing.Point(11, 43);
            this.textFirstNum.Multiline = true;
            this.textFirstNum.Name = "textFirstNum";
            this.textFirstNum.Size = new System.Drawing.Size(280, 60);
            this.textFirstNum.TabIndex = 18;
            this.textFirstNum.Text = "ПЕРВОЕ ЧИСЛО";
            // 
            // textAnswer
            // 
            this.textAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAnswer.Location = new System.Drawing.Point(11, 221);
            this.textAnswer.Multiline = true;
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(280, 60);
            this.textAnswer.TabIndex = 19;
            this.textAnswer.Text = "ОТВЕТ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 296);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.textFirstNum);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.textSecondNum);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Комплексные числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textSecondNum;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textFirstNum;
        private System.Windows.Forms.TextBox textAnswer;
    }
}

