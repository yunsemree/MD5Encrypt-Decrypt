namespace MD5Encrypt_Decrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            checkBox4 = new CheckBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textBox1.Location = new Point(179, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 30);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 1;
            label1.Text = "Metin";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(11, 47);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 3;
            label2.Text = "AES Key";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textBox2.Location = new Point(179, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(384, 30);
            textBox2.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(179, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 27);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Default Kullan";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox2.Location = new Point(325, 83);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(107, 27);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Net-9 İçin";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox3.Location = new Point(456, 83);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(115, 27);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Çöz-Şifrele";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(179, 149);
            button1.Name = "button1";
            button1.Size = new Size(384, 68);
            button1.TabIndex = 7;
            button1.Text = "Şifrele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox4.Location = new Point(179, 116);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(137, 27);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "MD-5 Oluştur";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(18, 233);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(718, 205);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(586, 155);
            button2.Name = "button2";
            button2.Size = new Size(94, 62);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(586, 13);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(125, 120);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 450);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(checkBox4);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private CheckBox checkBox4;
        private RichTextBox richTextBox1;
        private Button button2;
        private RichTextBox richTextBox2;
    }
}
