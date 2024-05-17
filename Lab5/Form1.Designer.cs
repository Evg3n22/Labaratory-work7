namespace Lab5
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
            label2 = new MaterialSkin.Controls.MaterialLabel();
            comboBox1 = new ComboBox();
            label3 = new MaterialSkin.Controls.MaterialLabel();
            button1 = new MaterialSkin.Controls.MaterialButton();
            dateTimePicker1 = new DateTimePicker();
            label1 = new MaterialSkin.Controls.MaterialLabel();
            textBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            ComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Depth = 0;
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(383, 70);
            label2.MouseState = MaterialSkin.MouseState.HOVER;
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 17;
            label2.Text = "haircuts";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "По Даті", "По Іменах", "По Вартості" });
            comboBox1.Location = new Point(175, 304);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Depth = 0;
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(197, 268);
            label3.MouseState = MaterialSkin.MouseState.HOVER;
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 15;
            label3.Text = "Сортування по:";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Location = new Point(62, 300);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(78, 36);
            button1.TabIndex = 14;
            button1.Text = "Record";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(63, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(113, 70);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 11;
            label1.Text = "Client record";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Depth = 0;
            textBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            textBox1.Location = new Point(62, 127);
            textBox1.MouseState = MaterialSkin.MouseState.HOVER;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 41);
            textBox1.TabIndex = 22;
            textBox1.Text = "";
            // 
            // ComboBox2
            // 
            ComboBox2.AutoResize = false;
            ComboBox2.BackColor = Color.FromArgb(255, 255, 255);
            ComboBox2.Depth = 0;
            ComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBox2.DropDownHeight = 174;
            ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox2.DropDownWidth = 121;
            ComboBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboBox2.FormattingEnabled = true;
            ComboBox2.IntegralHeight = false;
            ComboBox2.ItemHeight = 43;
            ComboBox2.Items.AddRange(new object[] { "Crop 200", "Fade 150", "Shorty 300", "Nalyso 5" });
            ComboBox2.Location = new Point(357, 127);
            ComboBox2.MaxDropDownItems = 4;
            ComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            ComboBox2.Name = "ComboBox2";
            ComboBox2.Size = new Size(151, 49);
            ComboBox2.StartIndex = 0;
            ComboBox2.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 402);
            Controls.Add(ComboBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel label2;
        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialButton button1;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textBox1;
        private MaterialSkin.Controls.MaterialComboBox ComboBox2;
    }
}
