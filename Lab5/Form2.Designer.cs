namespace Lab5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new MaterialSkin.Controls.MaterialLabel();
            label2 = new MaterialSkin.Controls.MaterialLabel();
            textBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            TextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            button1 = new MaterialSkin.Controls.MaterialButton();
            Button3 = new MaterialSkin.Controls.MaterialButton();
            Button4 = new MaterialSkin.Controls.MaterialButton();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(80, 47);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 0;
            label1.Text = "Client list";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Depth = 0;
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(392, 93);
            label2.MouseState = MaterialSkin.MouseState.HOVER;
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 2;
            label2.Text = "Money (Total)";
            // 
            // textBox1
            // 
            textBox1.AnimateReadOnly = false;
            textBox1.BackgroundImageLayout = ImageLayout.None;
            textBox1.CharacterCasing = CharacterCasing.Normal;
            textBox1.Depth = 0;
            textBox1.HideSelection = true;
            textBox1.Location = new Point(360, 138);
            textBox1.MaxLength = 32767;
            textBox1.MouseState = MaterialSkin.MouseState.OUT;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '\0';
            textBox1.ReadOnly = false;
            textBox1.ScrollBars = ScrollBars.None;
            textBox1.SelectedText = "";
            textBox1.SelectionLength = 0;
            textBox1.SelectionStart = 0;
            textBox1.ShortcutsEnabled = true;
            textBox1.Size = new Size(236, 40);
            textBox1.TabIndex = 3;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(392, 206);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(123, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Write client name";
            // 
            // TextBox2
            // 
            TextBox2.AnimateReadOnly = false;
            TextBox2.BackgroundImageLayout = ImageLayout.None;
            TextBox2.CharacterCasing = CharacterCasing.Normal;
            TextBox2.Depth = 0;
            TextBox2.HideSelection = true;
            TextBox2.Location = new Point(360, 240);
            TextBox2.MaxLength = 32767;
            TextBox2.MouseState = MaterialSkin.MouseState.OUT;
            TextBox2.Name = "TextBox2";
            TextBox2.PasswordChar = '\0';
            TextBox2.ReadOnly = false;
            TextBox2.ScrollBars = ScrollBars.None;
            TextBox2.SelectedText = "";
            TextBox2.SelectionLength = 0;
            TextBox2.SelectionStart = 0;
            TextBox2.ShortcutsEnabled = true;
            TextBox2.Size = new Size(236, 90);
            TextBox2.TabIndex = 5;
            TextBox2.TabStop = false;
            TextBox2.TextAlign = HorizontalAlignment.Left;
            TextBox2.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button1.Depth = 0;
            button1.HighEmphasis = true;
            button1.Icon = null;
            button1.Location = new Point(47, 373);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.MouseState = MaterialSkin.MouseState.HOVER;
            button1.Name = "button1";
            button1.NoAccentTextColor = Color.Empty;
            button1.Size = new Size(119, 36);
            button1.TabIndex = 6;
            button1.Text = "Serve client";
            button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button1.UseAccentColor = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Button3
            // 
            Button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Button3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Button3.Depth = 0;
            Button3.HighEmphasis = true;
            Button3.Icon = null;
            Button3.Location = new Point(247, 373);
            Button3.Margin = new Padding(4, 6, 4, 6);
            Button3.MouseState = MaterialSkin.MouseState.HOVER;
            Button3.Name = "Button3";
            Button3.NoAccentTextColor = Color.Empty;
            Button3.Size = new Size(127, 36);
            Button3.TabIndex = 7;
            Button3.Text = "Delete client";
            Button3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Button3.UseAccentColor = false;
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button3_Click_1;
            // 
            // Button4
            // 
            Button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Button4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Button4.Depth = 0;
            Button4.HighEmphasis = true;
            Button4.Icon = null;
            Button4.Location = new Point(438, 373);
            Button4.Margin = new Padding(4, 6, 4, 6);
            Button4.MouseState = MaterialSkin.MouseState.HOVER;
            Button4.Name = "Button4";
            Button4.NoAccentTextColor = Color.Empty;
            Button4.Size = new Size(107, 36);
            Button4.TabIndex = 8;
            Button4.Text = "Find client";
            Button4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Button4.UseAccentColor = false;
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(47, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 264);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(410, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 40);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 454);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(button1);
            Controls.Add(TextBox2);
            Controls.Add(materialLabel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TextBox2;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton Button3;
        private MaterialSkin.Controls.MaterialButton Button4;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}