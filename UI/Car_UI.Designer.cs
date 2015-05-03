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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.carPanel.Location = new System.Drawing.Point(72, 56);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(323, 178);
            this.carPanel.TabIndex = 0;
            this.carPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.carPanel_Paint);
            // 
            // speedButton
            // 
            this.speedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speedButton.BackgroundImage")));
            this.speedButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedButton.Location = new System.Drawing.Point(232, 15);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(79, 23);
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
            this.label1.Location = new System.Drawing.Point(10, 20);
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
            this.currentInfoLabel.Location = new System.Drawing.Point(161, 20);
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
            this.speedBox.Location = new System.Drawing.Point(172, 15);
            this.speedBox.Name = "speedBox";
            this.speedBox.ReadOnly = true;
            this.speedBox.Size = new System.Drawing.Size(54, 22);
            this.speedBox.TabIndex = 8;
            this.speedBox.ValueChanged += new System.EventHandler(this.speedBox_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.speedBox);
            this.panel1.Controls.Add(this.speedButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.currentInfoLabel);
            this.panel1.Location = new System.Drawing.Point(816, 755);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 62);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(65, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 10);
            this.panel2.TabIndex = 31;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel12.Location = new System.Drawing.Point(1269, 40);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 475);
            this.panel12.TabIndex = 37;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel11.Location = new System.Drawing.Point(56, 305);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 451);
            this.panel11.TabIndex = 36;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel10.Location = new System.Drawing.Point(514, 557);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(764, 10);
            this.panel10.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(514, 505);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(765, 10);
            this.panel7.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(65, 305);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(725, 10);
            this.panel6.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(56, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 257);
            this.panel3.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel5.Location = new System.Drawing.Point(514, 520);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(821, 33);
            this.panel5.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel8.Location = new System.Drawing.Point(12, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(38, 819);
            this.panel8.TabIndex = 30;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel9.Location = new System.Drawing.Point(2, 266);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(788, 33);
            this.panel9.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel4.Location = new System.Drawing.Point(1286, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 814);
            this.panel4.TabIndex = 28;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel13.Location = new System.Drawing.Point(56, 810);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(752, 10);
            this.panel13.TabIndex = 40;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel14.Location = new System.Drawing.Point(56, 755);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(753, 10);
            this.panel14.TabIndex = 39;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel15.Location = new System.Drawing.Point(2, 771);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(806, 33);
            this.panel15.TabIndex = 38;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel16.Location = new System.Drawing.Point(1269, 557);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(10, 263);
            this.panel16.TabIndex = 41;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel17.Location = new System.Drawing.Point(514, 40);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(765, 10);
            this.panel17.TabIndex = 42;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel18.Location = new System.Drawing.Point(514, 1);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(821, 33);
            this.panel18.TabIndex = 43;
            // 
            // panel19
            // 
            this.panel19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel19.BackgroundImage")));
            this.panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel19.Location = new System.Drawing.Point(72, 1);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(436, 49);
            this.panel19.TabIndex = 44;
            // 
            // Car_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1336, 823);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentInfoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
    }
}

