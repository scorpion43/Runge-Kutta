﻿namespace Runge_Kutta
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowFirstGraphButton = new System.Windows.Forms.Button();
            this.ZTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CorrectionGraphZButton = new System.Windows.Forms.Button();
            this.CorrectionGraphYButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AmountOfPointsTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ErrorMaxTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EpochsTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TrainButton = new System.Windows.Forms.Button();
            this.ZResultLabel = new System.Windows.Forms.Label();
            this.YResultLabel = new System.Windows.Forms.Label();
            this.XResultLabel = new System.Windows.Forms.Label();
            this.ShowSecondGraphButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ZRadioButton = new System.Windows.Forms.RadioButton();
            this.YRadioButton = new System.Windows.Forms.RadioButton();
            this.XRadioButton = new System.Windows.Forms.RadioButton();
            this.StartPointTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountOfPointsToShowTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(21, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Points for Graph x(t), y(t), z(t)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ShowFirstGraphButton);
            this.groupBox1.Controls.Add(this.ZTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.YTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.XTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Values";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // HTextBox
            // 
            this.HTextBox.Location = new System.Drawing.Point(249, 63);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(63, 24);
            this.HTextBox.TabIndex = 7;
            this.HTextBox.Text = "0,1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "h";
            // 
            // ShowFirstGraphButton
            // 
            this.ShowFirstGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ShowFirstGraphButton.Location = new System.Drawing.Point(199, 121);
            this.ShowFirstGraphButton.Name = "ShowFirstGraphButton";
            this.ShowFirstGraphButton.Size = new System.Drawing.Size(160, 72);
            this.ShowFirstGraphButton.TabIndex = 2;
            this.ShowFirstGraphButton.Text = "Show Graph for x(t), y(t), z(t)";
            this.ShowFirstGraphButton.UseVisualStyleBackColor = true;
            this.ShowFirstGraphButton.Click += new System.EventHandler(this.ShowFirstGraphButton_Click);
            // 
            // ZTextBox
            // 
            this.ZTextBox.Location = new System.Drawing.Point(58, 60);
            this.ZTextBox.Name = "ZTextBox";
            this.ZTextBox.Size = new System.Drawing.Size(63, 24);
            this.ZTextBox.TabIndex = 5;
            this.ZTextBox.Text = "1";
            this.ZTextBox.TextChanged += new System.EventHandler(this.ZTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "z(0)";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(249, 33);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(63, 24);
            this.YTextBox.TabIndex = 3;
            this.YTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "y(0)";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(58, 30);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(63, 24);
            this.XTextBox.TabIndex = 1;
            this.XTextBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "x(0)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AmountOfPointsToShowTB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.StartPointTB);
            this.groupBox2.Controls.Add(this.CorrectionGraphZButton);
            this.groupBox2.Controls.Add(this.CorrectionGraphYButton);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.AmountOfPointsTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ErrorMaxTB);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.EpochsTB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TrainButton);
            this.groupBox2.Controls.Add(this.ZResultLabel);
            this.groupBox2.Controls.Add(this.YResultLabel);
            this.groupBox2.Controls.Add(this.XResultLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 421);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Training Option";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CorrectionGraphZButton
            // 
            this.CorrectionGraphZButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CorrectionGraphZButton.Location = new System.Drawing.Point(555, 333);
            this.CorrectionGraphZButton.Name = "CorrectionGraphZButton";
            this.CorrectionGraphZButton.Size = new System.Drawing.Size(143, 60);
            this.CorrectionGraphZButton.TabIndex = 25;
            this.CorrectionGraphZButton.Text = "Correction Graph for Z";
            this.CorrectionGraphZButton.UseVisualStyleBackColor = true;
            this.CorrectionGraphZButton.Click += new System.EventHandler(this.CorrectionGraphZButton_Click);
            // 
            // CorrectionGraphYButton
            // 
            this.CorrectionGraphYButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CorrectionGraphYButton.Location = new System.Drawing.Point(309, 335);
            this.CorrectionGraphYButton.Name = "CorrectionGraphYButton";
            this.CorrectionGraphYButton.Size = new System.Drawing.Size(143, 58);
            this.CorrectionGraphYButton.TabIndex = 24;
            this.CorrectionGraphYButton.Text = "Correction Graph for Y";
            this.CorrectionGraphYButton.UseVisualStyleBackColor = true;
            this.CorrectionGraphYButton.Click += new System.EventHandler(this.CorrectionGraphYButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button3.Location = new System.Drawing.Point(43, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 58);
            this.button3.TabIndex = 23;
            this.button3.Text = "Correction Graph for X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AmountOfPointsTB
            // 
            this.AmountOfPointsTB.Location = new System.Drawing.Point(318, 145);
            this.AmountOfPointsTB.Name = "AmountOfPointsTB";
            this.AmountOfPointsTB.Size = new System.Drawing.Size(63, 24);
            this.AmountOfPointsTB.TabIndex = 22;
            this.AmountOfPointsTB.Text = "300";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(170, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Amount of Points:";
            // 
            // ErrorMaxTB
            // 
            this.ErrorMaxTB.Location = new System.Drawing.Point(511, 145);
            this.ErrorMaxTB.Name = "ErrorMaxTB";
            this.ErrorMaxTB.Size = new System.Drawing.Size(118, 24);
            this.ErrorMaxTB.TabIndex = 20;
            this.ErrorMaxTB.Text = "0,00001";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(422, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "ErrorMax:";
            // 
            // EpochsTB
            // 
            this.EpochsTB.Location = new System.Drawing.Point(91, 145);
            this.EpochsTB.Name = "EpochsTB";
            this.EpochsTB.Size = new System.Drawing.Size(63, 24);
            this.EpochsTB.TabIndex = 18;
            this.EpochsTB.Text = "1000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(21, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Epochs:";
            // 
            // TrainButton
            // 
            this.TrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TrainButton.Location = new System.Drawing.Point(555, 197);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(154, 46);
            this.TrainButton.TabIndex = 10;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // ZResultLabel
            // 
            this.ZResultLabel.AutoSize = true;
            this.ZResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ZResultLabel.Location = new System.Drawing.Point(16, 106);
            this.ZResultLabel.Name = "ZResultLabel";
            this.ZResultLabel.Size = new System.Drawing.Size(70, 20);
            this.ZResultLabel.TabIndex = 9;
            this.ZResultLabel.Text = "For Z(t):";
            // 
            // YResultLabel
            // 
            this.YResultLabel.AutoSize = true;
            this.YResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.YResultLabel.Location = new System.Drawing.Point(16, 76);
            this.YResultLabel.Name = "YResultLabel";
            this.YResultLabel.Size = new System.Drawing.Size(71, 20);
            this.YResultLabel.TabIndex = 8;
            this.YResultLabel.Text = "For Y(t):";
            // 
            // XResultLabel
            // 
            this.XResultLabel.AutoSize = true;
            this.XResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.XResultLabel.Location = new System.Drawing.Point(16, 48);
            this.XResultLabel.Name = "XResultLabel";
            this.XResultLabel.Size = new System.Drawing.Size(72, 20);
            this.XResultLabel.TabIndex = 7;
            this.XResultLabel.Text = "For X(t):";
            // 
            // ShowSecondGraphButton
            // 
            this.ShowSecondGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ShowSecondGraphButton.Location = new System.Drawing.Point(16, 90);
            this.ShowSecondGraphButton.Name = "ShowSecondGraphButton";
            this.ShowSecondGraphButton.Size = new System.Drawing.Size(317, 98);
            this.ShowSecondGraphButton.TabIndex = 5;
            this.ShowSecondGraphButton.Text = "Show Graph for choosen one";
            this.ShowSecondGraphButton.UseVisualStyleBackColor = true;
            this.ShowSecondGraphButton.Click += new System.EventHandler(this.ShowSecondGraphButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ZRadioButton);
            this.groupBox3.Controls.Add(this.YRadioButton);
            this.groupBox3.Controls.Add(this.XRadioButton);
            this.groupBox3.Controls.Add(this.ShowSecondGraphButton);
            this.groupBox3.Location = new System.Drawing.Point(388, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 203);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Graph 2D";
            // 
            // ZRadioButton
            // 
            this.ZRadioButton.AutoSize = true;
            this.ZRadioButton.Location = new System.Drawing.Point(295, 45);
            this.ZRadioButton.Name = "ZRadioButton";
            this.ZRadioButton.Size = new System.Drawing.Size(38, 21);
            this.ZRadioButton.TabIndex = 8;
            this.ZRadioButton.TabStop = true;
            this.ZRadioButton.Text = "Z";
            this.ZRadioButton.UseVisualStyleBackColor = true;
            // 
            // YRadioButton
            // 
            this.YRadioButton.AutoSize = true;
            this.YRadioButton.Location = new System.Drawing.Point(154, 45);
            this.YRadioButton.Name = "YRadioButton";
            this.YRadioButton.Size = new System.Drawing.Size(38, 21);
            this.YRadioButton.TabIndex = 7;
            this.YRadioButton.TabStop = true;
            this.YRadioButton.Text = "Y";
            this.YRadioButton.UseVisualStyleBackColor = true;
            // 
            // XRadioButton
            // 
            this.XRadioButton.AutoSize = true;
            this.XRadioButton.Checked = true;
            this.XRadioButton.Location = new System.Drawing.Point(16, 45);
            this.XRadioButton.Name = "XRadioButton";
            this.XRadioButton.Size = new System.Drawing.Size(38, 21);
            this.XRadioButton.TabIndex = 6;
            this.XRadioButton.TabStop = true;
            this.XRadioButton.Text = "X";
            this.XRadioButton.UseVisualStyleBackColor = true;
            // 
            // StartPointTB
            // 
            this.StartPointTB.Location = new System.Drawing.Point(138, 290);
            this.StartPointTB.Name = "StartPointTB";
            this.StartPointTB.Size = new System.Drawing.Size(63, 24);
            this.StartPointTB.TabIndex = 26;
            this.StartPointTB.Text = "300";
            this.StartPointTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(39, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Start Point:";
            // 
            // AmountOfPointsToShowTB
            // 
            this.AmountOfPointsToShowTB.Location = new System.Drawing.Point(393, 292);
            this.AmountOfPointsToShowTB.Name = "AmountOfPointsToShowTB";
            this.AmountOfPointsToShowTB.Size = new System.Drawing.Size(63, 24);
            this.AmountOfPointsToShowTB.TabIndex = 29;
            this.AmountOfPointsToShowTB.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(245, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Amount of Points:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 693);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox HTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ZTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowFirstGraphButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ShowSecondGraphButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ZRadioButton;
        private System.Windows.Forms.RadioButton YRadioButton;
        private System.Windows.Forms.RadioButton XRadioButton;
        private System.Windows.Forms.Label ZResultLabel;
        private System.Windows.Forms.Label YResultLabel;
        private System.Windows.Forms.Label XResultLabel;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.TextBox EpochsTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ErrorMaxTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AmountOfPointsTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CorrectionGraphZButton;
        private System.Windows.Forms.Button CorrectionGraphYButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartPointTB;
        private System.Windows.Forms.TextBox AmountOfPointsToShowTB;
        private System.Windows.Forms.Label label6;
    }
}

