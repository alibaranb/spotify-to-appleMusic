namespace NameEditor
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
            btn_ChoosePath = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            btn_Remove = new Button();
            label2 = new Label();
            btn_FixArtist = new Button();
            btn_LanEN = new Button();
            btn_LanTR = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 0;
            // 
            // btn_ChoosePath
            // 
            btn_ChoosePath.Location = new Point(186, 53);
            btn_ChoosePath.Name = "btn_ChoosePath";
            btn_ChoosePath.Size = new Size(75, 23);
            btn_ChoosePath.TabIndex = 1;
            btn_ChoosePath.Text = "Klasör seç";
            btn_ChoosePath.UseVisualStyleBackColor = true;
            btn_ChoosePath.Click += btn_ChoosePath_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 3;
            label1.Text = "Ne silmek istiyorsunuz?";
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(186, 146);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(75, 23);
            btn_Remove.TabIndex = 4;
            btn_Remove.Text = "Sil";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "Klasör yolu";
            // 
            // btn_FixArtist
            // 
            btn_FixArtist.Location = new Point(133, 197);
            btn_FixArtist.Name = "btn_FixArtist";
            btn_FixArtist.Size = new Size(191, 23);
            btn_FixArtist.TabIndex = 5;
            btn_FixArtist.Text = "Sanatçı isimlerini düzelt";
            btn_FixArtist.UseVisualStyleBackColor = true;
            btn_FixArtist.Click += btn_FixArtist_Click;
            // 
            // btn_LanEN
            // 
            btn_LanEN.FlatStyle = FlatStyle.Flat;
            btn_LanEN.Location = new Point(396, 222);
            btn_LanEN.Name = "btn_LanEN";
            btn_LanEN.Size = new Size(32, 24);
            btn_LanEN.TabIndex = 6;
            btn_LanEN.Text = "EN";
            btn_LanEN.UseVisualStyleBackColor = true;
            btn_LanEN.Click += btn_LanEN_Click;
            // 
            // btn_LanTR
            // 
            btn_LanTR.FlatStyle = FlatStyle.Flat;
            btn_LanTR.Location = new Point(358, 222);
            btn_LanTR.Name = "btn_LanTR";
            btn_LanTR.Size = new Size(32, 24);
            btn_LanTR.TabIndex = 6;
            btn_LanTR.Text = "TR";
            btn_LanTR.UseVisualStyleBackColor = true;
            btn_LanTR.Click += btn_LanTR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 258);
            Controls.Add(btn_LanTR);
            Controls.Add(btn_LanEN);
            Controls.Add(btn_FixArtist);
            Controls.Add(btn_Remove);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btn_ChoosePath);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Fraction - Spotify to Apple Music";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_ChoosePath;
        private TextBox textBox2;
        private Label label1;
        private Button btn_Remove;
        private Label label2;
        private Button btn_FixArtist;
        private Button btn_LanEN;
        private Button btn_LanTR;
    }
}