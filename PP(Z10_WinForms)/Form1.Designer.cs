namespace PP_Z10_WinForms_
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
            this.Zadanie = new System.Windows.Forms.GroupBox();
            this.Result = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.RichTextBox();
            this.Zadanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zadanie
            // 
            this.Zadanie.Controls.Add(this.Result);
            this.Zadanie.Controls.Add(this.information);
            this.Zadanie.Location = new System.Drawing.Point(2, 0);
            this.Zadanie.Name = "Zadanie";
            this.Zadanie.Size = new System.Drawing.Size(565, 758);
            this.Zadanie.TabIndex = 0;
            this.Zadanie.TabStop = false;
            this.Zadanie.Text = "Задание";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(173, 698);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(208, 54);
            this.Result.TabIndex = 1;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // information
            // 
            this.information.Location = new System.Drawing.Point(6, 21);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(551, 668);
            this.information.TabIndex = 0;
            this.information.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 761);
            this.Controls.Add(this.Zadanie);
            this.Name = "Form1";
            this.Text = "Практика 10";
            this.Zadanie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.RichTextBox information;
    }
}

