namespace Runge_Kutta
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
            this.ZTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowFirstGraphButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBoxForZ = new System.Windows.Forms.ListBox();
            this.ListBoxForY = new System.Windows.Forms.ListBox();
            this.ListBoxForX = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowSecondGraphButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.XRadioButton = new System.Windows.Forms.RadioButton();
            this.YRadioButton = new System.Windows.Forms.RadioButton();
            this.ZRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(21, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 72);
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
            this.groupBox1.Size = new System.Drawing.Size(585, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initial Values";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // HTextBox
            // 
            this.HTextBox.Location = new System.Drawing.Point(443, 33);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(63, 24);
            this.HTextBox.TabIndex = 7;
            this.HTextBox.Text = "0,1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "h";
            // 
            // ZTextBox
            // 
            this.ZTextBox.Location = new System.Drawing.Point(324, 30);
            this.ZTextBox.Name = "ZTextBox";
            this.ZTextBox.Size = new System.Drawing.Size(63, 24);
            this.ZTextBox.TabIndex = 5;
            this.ZTextBox.Text = "1";
            this.ZTextBox.TextChanged += new System.EventHandler(this.ZTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "z(0)";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(192, 30);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(63, 24);
            this.YTextBox.TabIndex = 3;
            this.YTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 33);
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
            // ShowFirstGraphButton
            // 
            this.ShowFirstGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ShowFirstGraphButton.Location = new System.Drawing.Point(306, 80);
            this.ShowFirstGraphButton.Name = "ShowFirstGraphButton";
            this.ShowFirstGraphButton.Size = new System.Drawing.Size(262, 72);
            this.ShowFirstGraphButton.TabIndex = 2;
            this.ShowFirstGraphButton.Text = "Show Graph for x(t), y(t), z(t)";
            this.ShowFirstGraphButton.UseVisualStyleBackColor = true;
            this.ShowFirstGraphButton.Click += new System.EventHandler(this.ShowFirstGraphButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListBoxForZ);
            this.groupBox2.Controls.Add(this.ListBoxForY);
            this.groupBox2.Controls.Add(this.ListBoxForX);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(17, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 366);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browse Values";
            // 
            // ListBoxForZ
            // 
            this.ListBoxForZ.FormattingEnabled = true;
            this.ListBoxForZ.ItemHeight = 18;
            this.ListBoxForZ.Location = new System.Drawing.Point(421, 66);
            this.ListBoxForZ.Name = "ListBoxForZ";
            this.ListBoxForZ.Size = new System.Drawing.Size(142, 292);
            this.ListBoxForZ.TabIndex = 6;
            this.ListBoxForZ.SelectedIndexChanged += new System.EventHandler(this.ListBoxForZ_SelectedIndexChanged);
            // 
            // ListBoxForY
            // 
            this.ListBoxForY.FormattingEnabled = true;
            this.ListBoxForY.ItemHeight = 18;
            this.ListBoxForY.Location = new System.Drawing.Point(212, 66);
            this.ListBoxForY.Name = "ListBoxForY";
            this.ListBoxForY.Size = new System.Drawing.Size(142, 292);
            this.ListBoxForY.TabIndex = 5;
            this.ListBoxForY.SelectedIndexChanged += new System.EventHandler(this.ListBoxForY_SelectedIndexChanged);
            // 
            // ListBoxForX
            // 
            this.ListBoxForX.FormattingEnabled = true;
            this.ListBoxForX.ItemHeight = 18;
            this.ListBoxForX.Location = new System.Drawing.Point(16, 66);
            this.ListBoxForX.Name = "ListBoxForX";
            this.ListBoxForX.Size = new System.Drawing.Size(142, 292);
            this.ListBoxForX.TabIndex = 4;
            this.ListBoxForX.SelectedIndexChanged += new System.EventHandler(this.ListBoxForX_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "z(t)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "y(t)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "x(t)";
            // 
            // ShowSecondGraphButton
            // 
            this.ShowSecondGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ShowSecondGraphButton.Location = new System.Drawing.Point(16, 86);
            this.ShowSecondGraphButton.Name = "ShowSecondGraphButton";
            this.ShowSecondGraphButton.Size = new System.Drawing.Size(547, 96);
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
            this.groupBox3.Location = new System.Drawing.Point(17, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 188);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Graph 2D";
            // 
            // XRadioButton
            // 
            this.XRadioButton.AutoSize = true;
            this.XRadioButton.Checked = true;
            this.XRadioButton.Location = new System.Drawing.Point(53, 36);
            this.XRadioButton.Name = "XRadioButton";
            this.XRadioButton.Size = new System.Drawing.Size(38, 21);
            this.XRadioButton.TabIndex = 6;
            this.XRadioButton.TabStop = true;
            this.XRadioButton.Text = "X";
            this.XRadioButton.UseVisualStyleBackColor = true;
            // 
            // YRadioButton
            // 
            this.YRadioButton.AutoSize = true;
            this.YRadioButton.Location = new System.Drawing.Point(252, 36);
            this.YRadioButton.Name = "YRadioButton";
            this.YRadioButton.Size = new System.Drawing.Size(38, 21);
            this.YRadioButton.TabIndex = 7;
            this.YRadioButton.TabStop = true;
            this.YRadioButton.Text = "Y";
            this.YRadioButton.UseVisualStyleBackColor = true;
            // 
            // ZRadioButton
            // 
            this.ZRadioButton.AutoSize = true;
            this.ZRadioButton.Location = new System.Drawing.Point(445, 36);
            this.ZRadioButton.Name = "ZRadioButton";
            this.ZRadioButton.Size = new System.Drawing.Size(38, 21);
            this.ZRadioButton.TabIndex = 8;
            this.ZRadioButton.TabStop = true;
            this.ZRadioButton.Text = "Z";
            this.ZRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 760);
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
        private System.Windows.Forms.ListBox ListBoxForZ;
        private System.Windows.Forms.ListBox ListBoxForY;
        private System.Windows.Forms.ListBox ListBoxForX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ShowSecondGraphButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ZRadioButton;
        private System.Windows.Forms.RadioButton YRadioButton;
        private System.Windows.Forms.RadioButton XRadioButton;
    }
}

