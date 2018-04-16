namespace GrainGrow2._0
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BundaryBox = new System.Windows.Forms.ComboBox();
            this.NeighborhoodBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EixitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StopButon = new System.Windows.Forms.Button();
            this.StartButon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeGenerateBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NumberGainLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberGainBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NumericSizeY = new System.Windows.Forms.NumericUpDown();
            this.NumericSizeX = new System.Windows.Forms.NumericUpDown();
            this.SetButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSizeX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(22, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SizeX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SizeY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BundaryBox);
            this.panel1.Controls.Add(this.NeighborhoodBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(653, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 188);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(41, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Boundary conditions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(55, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Neighborhood";
            // 
            // BundaryBox
            // 
            this.BundaryBox.FormattingEnabled = true;
            this.BundaryBox.Items.AddRange(new object[] {
            "Perodic",
            "No Perodic"});
            this.BundaryBox.Location = new System.Drawing.Point(15, 134);
            this.BundaryBox.Name = "BundaryBox";
            this.BundaryBox.Size = new System.Drawing.Size(170, 21);
            this.BundaryBox.TabIndex = 6;
            this.BundaryBox.SelectedIndexChanged += new System.EventHandler(this.BundaryBox_SelectedIndexChanged);
            // 
            // NeighborhoodBox
            // 
            this.NeighborhoodBox.FormattingEnabled = true;
            this.NeighborhoodBox.Items.AddRange(new object[] {
            "Von neuman",
            "Moore",
            "Heksagonal Left",
            "Heksagonal Right"});
            this.NeighborhoodBox.Location = new System.Drawing.Point(15, 73);
            this.NeighborhoodBox.Name = "NeighborhoodBox";
            this.NeighborhoodBox.Size = new System.Drawing.Size(170, 21);
            this.NeighborhoodBox.TabIndex = 7;
            this.NeighborhoodBox.SelectedIndexChanged += new System.EventHandler(this.NeighborhoodBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(37, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grain options";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.EixitButton);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.StopButon);
            this.panel2.Controls.Add(this.StartButon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(653, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 234);
            this.panel2.TabIndex = 4;
            // 
            // EixitButton
            // 
            this.EixitButton.Location = new System.Drawing.Point(30, 185);
            this.EixitButton.Name = "EixitButton";
            this.EixitButton.Size = new System.Drawing.Size(141, 23);
            this.EixitButton.TabIndex = 10;
            this.EixitButton.Text = "Exit";
            this.EixitButton.UseVisualStyleBackColor = true;
            this.EixitButton.Click += new System.EventHandler(this.EixitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(30, 134);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(141, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StopButon
            // 
            this.StopButon.Location = new System.Drawing.Point(30, 87);
            this.StopButon.Name = "StopButon";
            this.StopButon.Size = new System.Drawing.Size(141, 23);
            this.StopButon.TabIndex = 8;
            this.StopButon.Text = "Stop";
            this.StopButon.UseVisualStyleBackColor = true;
            this.StopButon.Click += new System.EventHandler(this.StopButon_Click);
            // 
            // StartButon
            // 
            this.StartButon.Enabled = false;
            this.StartButon.Location = new System.Drawing.Point(30, 41);
            this.StartButon.Name = "StartButon";
            this.StartButon.Size = new System.Drawing.Size(141, 23);
            this.StartButon.TabIndex = 7;
            this.StartButon.Text = "Start";
            this.StartButon.UseVisualStyleBackColor = true;
            this.StartButon.Click += new System.EventHandler(this.StartButon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Control grain";
            // 
            // TypeGenerateBox
            // 
            this.TypeGenerateBox.Enabled = false;
            this.TypeGenerateBox.FormattingEnabled = true;
            this.TypeGenerateBox.Items.AddRange(new object[] {
            "Random",
            "By clicking"});
            this.TypeGenerateBox.Location = new System.Drawing.Point(15, 75);
            this.TypeGenerateBox.Name = "TypeGenerateBox";
            this.TypeGenerateBox.Size = new System.Drawing.Size(170, 21);
            this.TypeGenerateBox.TabIndex = 5;
            this.TypeGenerateBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.NumberGainLabel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.NumberGainBox);
            this.panel3.Controls.Add(this.GenerateButton);
            this.panel3.Controls.Add(this.TypeGenerateBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(653, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 215);
            this.panel3.TabIndex = 5;
            // 
            // NumberGainLabel
            // 
            this.NumberGainLabel.AutoSize = true;
            this.NumberGainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberGainLabel.Location = new System.Drawing.Point(47, 112);
            this.NumberGainLabel.Name = "NumberGainLabel";
            this.NumberGainLabel.Size = new System.Drawing.Size(103, 16);
            this.NumberGainLabel.TabIndex = 9;
            this.NumberGainLabel.Text = "Number of grain";
            this.NumberGainLabel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(53, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Type generate";
            // 
            // NumberGainBox
            // 
            this.NumberGainBox.Location = new System.Drawing.Point(15, 142);
            this.NumberGainBox.Name = "NumberGainBox";
            this.NumberGainBox.Size = new System.Drawing.Size(170, 20);
            this.NumberGainBox.TabIndex = 7;
            this.NumberGainBox.Visible = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(30, 178);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(141, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Visible = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(26, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Generate grain";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.NumericSizeY);
            this.panel4.Controls.Add(this.NumericSizeX);
            this.panel4.Controls.Add(this.SetButton);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(128, 640);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 109);
            this.panel4.TabIndex = 11;
            // 
            // NumericSizeY
            // 
            this.NumericSizeY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericSizeY.Location = new System.Drawing.Point(124, 76);
            this.NumericSizeY.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NumericSizeY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericSizeY.Name = "NumericSizeY";
            this.NumericSizeY.ReadOnly = true;
            this.NumericSizeY.Size = new System.Drawing.Size(120, 20);
            this.NumericSizeY.TabIndex = 15;
            this.NumericSizeY.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // NumericSizeX
            // 
            this.NumericSizeX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericSizeX.Location = new System.Drawing.Point(124, 45);
            this.NumericSizeX.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NumericSizeX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericSizeX.Name = "NumericSizeX";
            this.NumericSizeX.ReadOnly = true;
            this.NumericSizeX.Size = new System.Drawing.Size(120, 20);
            this.NumericSizeX.TabIndex = 14;
            this.NumericSizeX.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(274, 68);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(104, 23);
            this.SetButton.TabIndex = 13;
            this.SetButton.Text = "Set ";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(144, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Window option";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Grain grow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSizeX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BundaryBox;
        private System.Windows.Forms.ComboBox NeighborhoodBox;
        private System.Windows.Forms.Button EixitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button StopButon;
        private System.Windows.Forms.Button StartButon;
        private System.Windows.Forms.ComboBox TypeGenerateBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumberGainBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NumberGainLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.NumericUpDown NumericSizeY;
        private System.Windows.Forms.NumericUpDown NumericSizeX;
        private System.Windows.Forms.Timer timer1;
    }
}

