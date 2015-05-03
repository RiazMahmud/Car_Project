namespace UI
{
    partial class Car_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_UI));
            this.carPanel = new System.Windows.Forms.Panel();
            this.speedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentInfoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedBox = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.carPanel.Location = new System.Drawing.Point(476, 258);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(398, 247);
            this.carPanel.TabIndex = 0;
            this.carPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.carPanel_Paint);
            // 
            // speedButton
            // 
            this.speedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speedButton.BackgroundImage")));
            this.speedButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedButton.Location = new System.Drawing.Point(736, 1);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(203, 26);
            this.speedButton.TabIndex = 2;
            this.speedButton.Text = "Set Speed";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(569, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Speed :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentInfoLabel
            // 
            this.currentInfoLabel.AutoSize = true;
            this.currentInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentInfoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentInfoLabel.Location = new System.Drawing.Point(757, 728);
            this.currentInfoLabel.Name = "currentInfoLabel";
            this.currentInfoLabel.Size = new System.Drawing.Size(0, 16);
            this.currentInfoLabel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedBox
            // 
            this.speedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speedBox.Location = new System.Drawing.Point(497, 4);
            this.speedBox.Name = "speedBox";
            this.speedBox.ReadOnly = true;
            this.speedBox.Size = new System.Drawing.Size(203, 22);
            this.speedBox.TabIndex = 8;
            this.speedBox.ValueChanged += new System.EventHandler(this.speedBox_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.speedButton);
            this.panel1.Controls.Add(this.speedBox);
            this.panel1.Location = new System.Drawing.Point(1, 752);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 29);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Location = new System.Drawing.Point(1, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 70);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel3.Location = new System.Drawing.Point(218, 546);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 203);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel4.Location = new System.Drawing.Point(1059, 546);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(72, 203);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel5.Location = new System.Drawing.Point(1118, 546);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 70);
            this.panel5.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel6.Location = new System.Drawing.Point(1059, -24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(72, 198);
            this.panel6.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel7.Location = new System.Drawing.Point(1118, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 55);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel8.Location = new System.Drawing.Point(196, -24);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(69, 198);
            this.panel8.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel9.Location = new System.Drawing.Point(1, 119);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 55);
            this.panel9.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel10.Location = new System.Drawing.Point(498, -24);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 160);
            this.panel10.TabIndex = 19;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel11.Location = new System.Drawing.Point(781, -24);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(30, 160);
            this.panel11.TabIndex = 20;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel12.Location = new System.Drawing.Point(498, 135);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(313, 39);
            this.panel12.TabIndex = 21;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel13.Location = new System.Drawing.Point(498, 546);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(313, 47);
            this.panel13.TabIndex = 24;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel14.Location = new System.Drawing.Point(773, 557);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(38, 192);
            this.panel14.TabIndex = 23;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel15.Location = new System.Drawing.Point(498, 570);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(38, 180);
            this.panel15.TabIndex = 22;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel16.Location = new System.Drawing.Point(1, 274);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(30, 165);
            this.panel16.TabIndex = 25;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel17.Location = new System.Drawing.Point(1306, 274);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(30, 165);
            this.panel17.TabIndex = 26;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel18.Location = new System.Drawing.Point(293, 135);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(157, 39);
            this.panel18.TabIndex = 27;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel19.Location = new System.Drawing.Point(859, 135);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(157, 39);
            this.panel19.TabIndex = 28;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel20.Location = new System.Drawing.Point(315, 546);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(157, 39);
            this.panel20.TabIndex = 29;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel21.Location = new System.Drawing.Point(859, 546);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(157, 39);
            this.panel21.TabIndex = 30;
            // 
            // Car_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1336, 781);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Car_UI";
            this.Text = "Car Animation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentInfoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
    }
}

