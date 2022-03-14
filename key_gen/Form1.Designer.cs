namespace key_gen
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
            this.key_button = new System.Windows.Forms.Button();
            this.key_input = new System.Windows.Forms.TextBox();
            this.key_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // key_button
            // 
            this.key_button.Location = new System.Drawing.Point(12, 64);
            this.key_button.Name = "key_button";
            this.key_button.Size = new System.Drawing.Size(332, 27);
            this.key_button.TabIndex = 0;
            this.key_button.Text = "Получить код";
            this.key_button.UseVisualStyleBackColor = true;
            this.key_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // key_input
            // 
            this.key_input.Location = new System.Drawing.Point(12, 12);
            this.key_input.Name = "key_input";
            this.key_input.Size = new System.Drawing.Size(332, 20);
            this.key_input.TabIndex = 1;
            this.key_input.Text = "Сюда ввести код с программы";
            this.key_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // key_out
            // 
            this.key_out.Location = new System.Drawing.Point(12, 38);
            this.key_out.Name = "key_out";
            this.key_out.ReadOnly = true;
            this.key_out.Size = new System.Drawing.Size(332, 20);
            this.key_out.TabIndex = 2;
            this.key_out.Text = "Здесь будет результат";
            this.key_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 107);
            this.Controls.Add(this.key_out);
            this.Controls.Add(this.key_input);
            this.Controls.Add(this.key_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ключ к конфигуратору SC11.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button key_button;
        private System.Windows.Forms.TextBox key_input;
        private System.Windows.Forms.TextBox key_out;
    }
}

