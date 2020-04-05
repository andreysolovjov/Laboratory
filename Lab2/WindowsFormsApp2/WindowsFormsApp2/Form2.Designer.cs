namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picResultColor = new System.Windows.Forms.PictureBox();
            this.Scroll_Red = new System.Windows.Forms.HScrollBar();
            this.Scroll_Green = new System.Windows.Forms.HScrollBar();
            this.Scroll_Blue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_Red = new System.Windows.Forms.NumericUpDown();
            this.numeric_Green = new System.Windows.Forms.NumericUpDown();
            this.numeric_Blue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Other Colors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // picResultColor
            // 
            this.picResultColor.Location = new System.Drawing.Point(450, 50);
            this.picResultColor.Name = "picResultColor";
            this.picResultColor.Size = new System.Drawing.Size(132, 115);
            this.picResultColor.TabIndex = 3;
            this.picResultColor.TabStop = false;
            this.picResultColor.Click += new System.EventHandler(this.picResultColor_Click);
            // 
            // Scroll_Red
            // 
            this.Scroll_Red.LargeChange = 1;
            this.Scroll_Red.Location = new System.Drawing.Point(96, 50);
            this.Scroll_Red.Maximum = 255;
            this.Scroll_Red.Name = "Scroll_Red";
            this.Scroll_Red.Size = new System.Drawing.Size(250, 20);
            this.Scroll_Red.TabIndex = 4;
            this.Scroll_Red.ValueChanged += new System.EventHandler(this.Scroll_Red_ValueChanged);
            // 
            // Scroll_Green
            // 
            this.Scroll_Green.LargeChange = 1;
            this.Scroll_Green.Location = new System.Drawing.Point(96, 97);
            this.Scroll_Green.Maximum = 255;
            this.Scroll_Green.Name = "Scroll_Green";
            this.Scroll_Green.Size = new System.Drawing.Size(250, 20);
            this.Scroll_Green.TabIndex = 5;
            this.Scroll_Green.ValueChanged += new System.EventHandler(this.Scroll_Green_ValueChanged);
            // 
            // Scroll_Blue
            // 
            this.Scroll_Blue.LargeChange = 1;
            this.Scroll_Blue.Location = new System.Drawing.Point(96, 145);
            this.Scroll_Blue.Maximum = 255;
            this.Scroll_Blue.Name = "Scroll_Blue";
            this.Scroll_Blue.Size = new System.Drawing.Size(250, 20);
            this.Scroll_Blue.TabIndex = 6;
            this.Scroll_Blue.ValueChanged += new System.EventHandler(this.Scroll_Blue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Red";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Blue";
            // 
            // numeric_Red
            // 
            this.numeric_Red.Location = new System.Drawing.Point(369, 50);
            this.numeric_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Red.Name = "numeric_Red";
            this.numeric_Red.Size = new System.Drawing.Size(56, 20);
            this.numeric_Red.TabIndex = 10;
            this.numeric_Red.ValueChanged += new System.EventHandler(this.numeric_Red_ValueChanged);
            // 
            // numeric_Green
            // 
            this.numeric_Green.Location = new System.Drawing.Point(369, 97);
            this.numeric_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Green.Name = "numeric_Green";
            this.numeric_Green.Size = new System.Drawing.Size(56, 20);
            this.numeric_Green.TabIndex = 11;
            this.numeric_Green.ValueChanged += new System.EventHandler(this.numeric_Green_ValueChanged);
            // 
            // numeric_Blue
            // 
            this.numeric_Blue.Location = new System.Drawing.Point(369, 145);
            this.numeric_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_Blue.Name = "numeric_Blue";
            this.numeric_Blue.Size = new System.Drawing.Size(56, 20);
            this.numeric_Blue.TabIndex = 12;
            this.numeric_Blue.ValueChanged += new System.EventHandler(this.numeric_Blue_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 326);
            this.Controls.Add(this.numeric_Blue);
            this.Controls.Add(this.numeric_Green);
            this.Controls.Add(this.numeric_Red);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scroll_Blue);
            this.Controls.Add(this.Scroll_Green);
            this.Controls.Add(this.Scroll_Red);
            this.Controls.Add(this.picResultColor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picResultColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox picResultColor;
        private System.Windows.Forms.HScrollBar Scroll_Red;
        private System.Windows.Forms.HScrollBar Scroll_Green;
        private System.Windows.Forms.HScrollBar Scroll_Blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_Red;
        private System.Windows.Forms.NumericUpDown numeric_Green;
        private System.Windows.Forms.NumericUpDown numeric_Blue;
    }
}