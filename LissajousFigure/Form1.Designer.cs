namespace LissajousFigure
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.label_fb = new System.Windows.Forms.Label();
            this.label_shift = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label_fa = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.button_load_from_file = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 365);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(578, 254);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(105, 20);
            this.textBox_b.TabIndex = 1;
            // 
            // textBox_f
            // 
            this.textBox_f.Location = new System.Drawing.Point(578, 289);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(105, 20);
            this.textBox_f.TabIndex = 2;
            // 
            // label_fb
            // 
            this.label_fb.AutoSize = true;
            this.label_fb.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fb.Location = new System.Drawing.Point(457, 256);
            this.label_fb.Name = "label_fb";
            this.label_fb.Size = new System.Drawing.Size(87, 18);
            this.label_fb.TabIndex = 3;
            this.label_fb.Text = "Frequency b:";
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shift.Location = new System.Drawing.Point(466, 291);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(78, 18);
            this.label_shift.TabIndex = 4;
            this.label_shift.Text = "Phase shift:";
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Go.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.Location = new System.Drawing.Point(599, 334);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(108, 43);
            this.Go.TabIndex = 5;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.DrawFigure);
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(578, 219);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(105, 20);
            this.textBox_a.TabIndex = 1;
            // 
            // label_fa
            // 
            this.label_fa.AutoSize = true;
            this.label_fa.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fa.Location = new System.Drawing.Point(458, 219);
            this.label_fa.Name = "label_fa";
            this.label_fa.Size = new System.Drawing.Size(86, 18);
            this.label_fa.TabIndex = 3;
            this.label_fa.Text = "Frequency a:";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(578, 183);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(105, 20);
            this.textBoxB.TabIndex = 2;
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B.Location = new System.Drawing.Point(458, 185);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(89, 18);
            this.label_B.TabIndex = 4;
            this.label_B.Text = "Amplitude В:";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(578, 147);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(105, 20);
            this.textBoxA.TabIndex = 2;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A.Location = new System.Drawing.Point(458, 149);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(90, 18);
            this.label_A.TabIndex = 4;
            this.label_A.Text = "Amplitude А:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(492, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 48);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(491, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(159, 26);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Lissajous figures";
            // 
            // button_load_from_file
            // 
            this.button_load_from_file.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_load_from_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_load_from_file.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load_from_file.Location = new System.Drawing.Point(449, 334);
            this.button_load_from_file.Name = "button_load_from_file";
            this.button_load_from_file.Size = new System.Drawing.Size(126, 43);
            this.button_load_from_file.TabIndex = 8;
            this.button_load_from_file.Text = "Load settings from text  file";
            this.button_load_from_file.UseVisualStyleBackColor = false;
            this.button_load_from_file.Click += new System.EventHandler(this.LoadFromFile);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(719, 389);
            this.Controls.Add(this.button_load_from_file);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_shift);
            this.Controls.Add(this.label_fa);
            this.Controls.Add(this.label_fb);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBox_f);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lissajous figures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.Label label_fb;
        private System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label_fa;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_load_from_file;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

