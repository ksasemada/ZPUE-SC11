
namespace SC11_IEC101_config
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
            this.save_id_com_cb = new System.Windows.Forms.ComboBox();
            this.save_speed_com_cb = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.save_asdu_com_cb = new System.Windows.Forms.ComboBox();
            this.log_txt_richTextBox = new System.Windows.Forms.RichTextBox();
            this.save_asdu_com_label = new System.Windows.Forms.Label();
            this.list_com_cb = new System.Windows.Forms.ComboBox();
            this.save_id_com_label = new System.Windows.Forms.Label();
            this.save_speed_com_label = new System.Windows.Forms.Label();
            this.save_prot_com_label = new System.Windows.Forms.Label();
            this.save_prot_com_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.save_id_com_cb.Location = new System.Drawing.Point(228, 76);
            this.save_id_com_cb.Name = "save_id_com_cb";
            this.save_id_com_cb.Size = new System.Drawing.Size(102, 21);
            this.save_id_com_cb.TabIndex = 80;
            this.save_id_com_cb.Visible = false;
            // 
            // save_speed_com_cb
            // 
            this.save_speed_com_cb.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.save_speed_com_cb.Location = new System.Drawing.Point(228, 49);
            this.save_speed_com_cb.Name = "save_speed_com_cb";
            this.save_speed_com_cb.Size = new System.Drawing.Size(102, 21);
            this.save_speed_com_cb.TabIndex = 79;
            this.save_speed_com_cb.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(228, 130);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(102, 27);
            this.save_button.TabIndex = 78;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Visible = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(12, 42);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(102, 27);
            this.connect_button.TabIndex = 81;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // save_asdu_com_cb
            // 
            this.save_asdu_com_cb.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.save_asdu_com_cb.Items.AddRange(new object[] {
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
            this.save_asdu_com_cb.Location = new System.Drawing.Point(228, 103);
            this.save_asdu_com_cb.Name = "save_asdu_com_cb";
            this.save_asdu_com_cb.Size = new System.Drawing.Size(102, 21);
            this.save_asdu_com_cb.TabIndex = 82;
            this.save_asdu_com_cb.Visible = false;
            // 
            // log_txt_richTextBox
            // 
            this.log_txt_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.log_txt_richTextBox.Location = new System.Drawing.Point(7, 163);
            this.log_txt_richTextBox.Name = "log_txt_richTextBox";
            this.log_txt_richTextBox.Size = new System.Drawing.Size(397, 129);
            this.log_txt_richTextBox.TabIndex = 83;
            this.log_txt_richTextBox.Text = "";
            // 
            // save_asdu_com_label
            // 
            this.save_asdu_com_label.AutoSize = true;
            this.save_asdu_com_label.Location = new System.Drawing.Point(336, 106);
            this.save_asdu_com_label.Name = "save_asdu_com_label";
            this.save_asdu_com_label.Size = new System.Drawing.Size(77, 13);
            this.save_asdu_com_label.TabIndex = 84;
            this.save_asdu_com_label.Text = "ASDU address";
            this.save_asdu_com_label.Visible = false;
            // 
            // list_com_cb
            // 
            this.list_com_cb.FormattingEnabled = true;
            this.list_com_cb.Location = new System.Drawing.Point(12, 12);
            this.list_com_cb.Name = "list_com_cb";
            this.list_com_cb.Size = new System.Drawing.Size(102, 21);
            this.list_com_cb.TabIndex = 87;
            // 
            // save_id_com_label
            // 
            this.save_id_com_label.AutoSize = true;
            this.save_id_com_label.Location = new System.Drawing.Point(336, 79);
            this.save_id_com_label.Name = "save_id_com_label";
            this.save_id_com_label.Size = new System.Drawing.Size(39, 13);
            this.save_id_com_label.TabIndex = 89;
            this.save_id_com_label.Text = "Adress";
            this.save_id_com_label.Visible = false;
            // 
            // save_speed_com_label
            // 
            this.save_speed_com_label.AutoSize = true;
            this.save_speed_com_label.Location = new System.Drawing.Point(336, 52);
            this.save_speed_com_label.Name = "save_speed_com_label";
            this.save_speed_com_label.Size = new System.Drawing.Size(38, 13);
            this.save_speed_com_label.TabIndex = 88;
            this.save_speed_com_label.Text = "Speed";
            this.save_speed_com_label.Visible = false;
            // 
            // save_prot_com_label
            // 
            this.save_prot_com_label.AutoSize = true;
            this.save_prot_com_label.Location = new System.Drawing.Point(336, 25);
            this.save_prot_com_label.Name = "save_prot_com_label";
            this.save_prot_com_label.Size = new System.Drawing.Size(46, 13);
            this.save_prot_com_label.TabIndex = 91;
            this.save_prot_com_label.Text = "Protocol";
            this.save_prot_com_label.Visible = false;
            // 
            // save_prot_com_cb
            // 
            this.save_prot_com_cb.Items.AddRange(new object[] {
            "modbus",
            "iec101"});
            this.save_prot_com_cb.Location = new System.Drawing.Point(228, 22);
            this.save_prot_com_cb.Name = "save_prot_com_cb";
            this.save_prot_com_cb.Size = new System.Drawing.Size(102, 21);
            this.save_prot_com_cb.TabIndex = 90;
            this.save_prot_com_cb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "ksa.semada@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_prot_com_label);
            this.Controls.Add(this.save_prot_com_cb);
            this.Controls.Add(this.save_id_com_label);
            this.Controls.Add(this.save_speed_com_label);
            this.Controls.Add(this.list_com_cb);
            this.Controls.Add(this.save_asdu_com_label);
            this.Controls.Add(this.log_txt_richTextBox);
            this.Controls.Add(this.save_asdu_com_cb);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.save_id_com_cb);
            this.Controls.Add(this.save_speed_com_cb);
            this.Controls.Add(this.save_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SC11 config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox save_id_com_cb;
        private System.Windows.Forms.ComboBox save_speed_com_cb;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.ComboBox save_asdu_com_cb;
        private System.Windows.Forms.RichTextBox log_txt_richTextBox;
        private System.Windows.Forms.Label save_asdu_com_label;
        private System.Windows.Forms.ComboBox list_com_cb;
        private System.Windows.Forms.Label save_id_com_label;
        private System.Windows.Forms.Label save_speed_com_label;
        private System.Windows.Forms.Label save_prot_com_label;
        private System.Windows.Forms.ComboBox save_prot_com_cb;
        private System.Windows.Forms.Label label1;
    }
}

