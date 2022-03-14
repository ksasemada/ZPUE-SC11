namespace modbus
{
    partial class com_reload
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(com_reload));
            this.list_com_cb = new System.Windows.Forms.ComboBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.refreash = new System.Windows.Forms.Timer(this.components);
            this.speed_com_cb = new System.Windows.Forms.ComboBox();
            this.log_txt_richTextBox = new System.Windows.Forms.RichTextBox();
            this.id_com_cb = new System.Windows.Forms.ComboBox();
            this.text1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_id_com_label = new System.Windows.Forms.Label();
            this.save_speed_com_label = new System.Windows.Forms.Label();
            this.save_id_com_cb = new System.Windows.Forms.ComboBox();
            this.save_speed_com_cb = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_com_cb
            // 
            this.list_com_cb.FormattingEnabled = true;
            this.list_com_cb.Location = new System.Drawing.Point(12, 12);
            this.list_com_cb.Name = "list_com_cb";
            this.list_com_cb.Size = new System.Drawing.Size(86, 21);
            this.list_com_cb.TabIndex = 0;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(12, 93);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(147, 27);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Подключиться";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // refreash
            // 
            this.refreash.Interval = 500;
            this.refreash.Tick += new System.EventHandler(this.refreash_Tick);
            // 
            // speed_com_cb
            // 
            this.speed_com_cb.FormattingEnabled = true;
            this.speed_com_cb.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.speed_com_cb.Location = new System.Drawing.Point(12, 39);
            this.speed_com_cb.Name = "speed_com_cb";
            this.speed_com_cb.Size = new System.Drawing.Size(86, 21);
            this.speed_com_cb.TabIndex = 3;
            // 
            // log_txt_richTextBox
            // 
            this.log_txt_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.log_txt_richTextBox.Location = new System.Drawing.Point(12, 135);
            this.log_txt_richTextBox.Name = "log_txt_richTextBox";
            this.log_txt_richTextBox.Size = new System.Drawing.Size(397, 175);
            this.log_txt_richTextBox.TabIndex = 41;
            this.log_txt_richTextBox.Text = "";
            // 
            // id_com_cb
            // 
            this.id_com_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.id_com_cb.FormattingEnabled = true;
            this.id_com_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.id_com_cb.Location = new System.Drawing.Point(12, 66);
            this.id_com_cb.Name = "id_com_cb";
            this.id_com_cb.Size = new System.Drawing.Size(86, 21);
            this.id_com_cb.TabIndex = 42;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(104, 42);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(55, 13);
            this.text1.TabIndex = 70;
            this.text1.Text = "Скорость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Порт";
            // 
            // save_id_com_label
            // 
            this.save_id_com_label.AutoSize = true;
            this.save_id_com_label.Location = new System.Drawing.Point(338, 69);
            this.save_id_com_label.Name = "save_id_com_label";
            this.save_id_com_label.Size = new System.Drawing.Size(38, 13);
            this.save_id_com_label.TabIndex = 78;
            this.save_id_com_label.Text = "Адрес";
            this.save_id_com_label.Visible = false;
            // 
            // save_speed_com_label
            // 
            this.save_speed_com_label.AutoSize = true;
            this.save_speed_com_label.Location = new System.Drawing.Point(338, 42);
            this.save_speed_com_label.Name = "save_speed_com_label";
            this.save_speed_com_label.Size = new System.Drawing.Size(55, 13);
            this.save_speed_com_label.TabIndex = 77;
            this.save_speed_com_label.Text = "Скорость";
            this.save_speed_com_label.Visible = false;
            // 
            // save_id_com_cb
            // 
            this.save_id_com_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.save_id_com_cb.FormattingEnabled = true;
            this.save_id_com_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.save_id_com_cb.Location = new System.Drawing.Point(246, 66);
            this.save_id_com_cb.Name = "save_id_com_cb";
            this.save_id_com_cb.Size = new System.Drawing.Size(86, 21);
            this.save_id_com_cb.TabIndex = 76;
            this.save_id_com_cb.Visible = false;
            // 
            // save_speed_com_cb
            // 
            this.save_speed_com_cb.FormattingEnabled = true;
            this.save_speed_com_cb.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.save_speed_com_cb.Location = new System.Drawing.Point(246, 39);
            this.save_speed_com_cb.Name = "save_speed_com_cb";
            this.save_speed_com_cb.Size = new System.Drawing.Size(86, 21);
            this.save_speed_com_cb.TabIndex = 75;
            this.save_speed_com_cb.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(246, 93);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(147, 27);
            this.save_button.TabIndex = 74;
            this.save_button.Text = "Записать";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Visible = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // com_reload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 325);
            this.Controls.Add(this.save_id_com_label);
            this.Controls.Add(this.save_speed_com_label);
            this.Controls.Add(this.save_id_com_cb);
            this.Controls.Add(this.save_speed_com_cb);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.id_com_cb);
            this.Controls.Add(this.log_txt_richTextBox);
            this.Controls.Add(this.speed_com_cb);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.list_com_cb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "com_reload";
            this.Text = "Настройка SC11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox list_com_cb;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Timer refreash;
        private System.Windows.Forms.ComboBox speed_com_cb;
        private System.Windows.Forms.RichTextBox log_txt_richTextBox;
        private System.Windows.Forms.ComboBox id_com_cb;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label save_id_com_label;
        private System.Windows.Forms.Label save_speed_com_label;
        private System.Windows.Forms.ComboBox save_id_com_cb;
        private System.Windows.Forms.ComboBox save_speed_com_cb;
        private System.Windows.Forms.Button save_button;
    }
}

