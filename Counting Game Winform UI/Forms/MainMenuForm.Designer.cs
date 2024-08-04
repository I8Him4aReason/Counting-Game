namespace Counting_Game_Winform_UI.Forms
{
    partial class MainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxRange = new System.Windows.Forms.NumericUpDown();
            this.DifficultyTrackBar = new System.Windows.Forms.TrackBar();
            this.NextButton = new System.Windows.Forms.Button();
            this.ComputerStartsCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinRange = new System.Windows.Forms.NumericUpDown();
            this.TargetNumberLabel = new System.Windows.Forms.Label();
            this.TargetNum = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CheckedPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ModeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetNum)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(531, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "בס\"ד";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main Menu";
            // 
            // MaxRange
            // 
            this.MaxRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxRange.Location = new System.Drawing.Point(347, 61);
            this.MaxRange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxRange.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MaxRange.Name = "MaxRange";
            this.MaxRange.Size = new System.Drawing.Size(135, 35);
            this.MaxRange.TabIndex = 3;
            this.MaxRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxRange.ValueChanged += new System.EventHandler(this.MaxRange_ValueChanged);
            // 
            // DifficultyTrackBar
            // 
            this.DifficultyTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DifficultyTrackBar.Location = new System.Drawing.Point(197, 25);
            this.DifficultyTrackBar.Maximum = 250;
            this.DifficultyTrackBar.Minimum = 1;
            this.DifficultyTrackBar.Name = "DifficultyTrackBar";
            this.DifficultyTrackBar.Size = new System.Drawing.Size(298, 45);
            this.DifficultyTrackBar.TabIndex = 5;
            this.DifficultyTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.DifficultyTrackBar.Value = 100;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.Lime;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NextButton.FlatAppearance.BorderSize = 3;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NextButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NextButton.Location = new System.Drawing.Point(425, 496);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(149, 71);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ComputerStartsCheckBox
            // 
            this.ComputerStartsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ComputerStartsCheckBox.AutoSize = true;
            this.ComputerStartsCheckBox.Checked = true;
            this.ComputerStartsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ComputerStartsCheckBox.Location = new System.Drawing.Point(10, 12);
            this.ComputerStartsCheckBox.Name = "ComputerStartsCheckBox";
            this.ComputerStartsCheckBox.Size = new System.Drawing.Size(207, 31);
            this.ComputerStartsCheckBox.TabIndex = 4;
            this.ComputerStartsCheckBox.Text = "Computer Starts";
            this.ComputerStartsCheckBox.UseVisualStyleBackColor = true;
            this.ComputerStartsCheckBox.CheckedChanged += new System.EventHandler(this.ComputerStartsCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Range Of Numbers Allowed To Be Used:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Difficulty:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(190, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Easy";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(453, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hard";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.MinRange);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MaxRange);
            this.panel2.Location = new System.Drawing.Point(50, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 114);
            this.panel2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Min:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Max:";
            // 
            // MinRange
            // 
            this.MinRange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MinRange.Location = new System.Drawing.Point(82, 61);
            this.MinRange.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.MinRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinRange.Name = "MinRange";
            this.MinRange.Size = new System.Drawing.Size(135, 35);
            this.MinRange.TabIndex = 2;
            this.MinRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinRange.ValueChanged += new System.EventHandler(this.MinRange_ValueChanged);
            // 
            // TargetNumberLabel
            // 
            this.TargetNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TargetNumberLabel.AutoSize = true;
            this.TargetNumberLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TargetNumberLabel.ForeColor = System.Drawing.Color.White;
            this.TargetNumberLabel.Location = new System.Drawing.Point(3, 13);
            this.TargetNumberLabel.Name = "TargetNumberLabel";
            this.TargetNumberLabel.Size = new System.Drawing.Size(178, 27);
            this.TargetNumberLabel.TabIndex = 9;
            this.TargetNumberLabel.Text = "Target Number:";
            // 
            // TargetNum
            // 
            this.TargetNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetNum.Location = new System.Drawing.Point(347, 11);
            this.TargetNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TargetNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TargetNum.Name = "TargetNum";
            this.TargetNum.Size = new System.Drawing.Size(135, 35);
            this.TargetNum.TabIndex = 1;
            this.TargetNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TargetNumberLabel);
            this.panel3.Controls.Add(this.TargetNum);
            this.panel3.Location = new System.Drawing.Point(50, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 57);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CheckedPanel);
            this.panel4.Controls.Add(this.ComputerStartsCheckBox);
            this.panel4.Location = new System.Drawing.Point(50, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 57);
            this.panel4.TabIndex = 13;
            // 
            // CheckedPanel
            // 
            this.CheckedPanel.BackColor = System.Drawing.Color.SpringGreen;
            this.CheckedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckedPanel.Location = new System.Drawing.Point(7, 17);
            this.CheckedPanel.Name = "CheckedPanel";
            this.CheckedPanel.Size = new System.Drawing.Size(18, 18);
            this.CheckedPanel.TabIndex = 5;
            this.CheckedPanel.Click += new System.EventHandler(this.CheckedPanel_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.DifficultyTrackBar);
            this.panel5.Location = new System.Drawing.Point(50, 380);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 83);
            this.panel5.TabIndex = 14;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Lime;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackButton.FlatAppearance.BorderSize = 3;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 54);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetButton.BackColor = System.Drawing.Color.Lime;
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResetButton.FlatAppearance.BorderSize = 3;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ResetButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ResetButton.Location = new System.Drawing.Point(50, 496);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(99, 47);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ModeLabel
            // 
            this.ModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ModeLabel.ForeColor = System.Drawing.Color.White;
            this.ModeLabel.Location = new System.Drawing.Point(452, 61);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(98, 27);
            this.ModeLabel.TabIndex = 13;
            this.ModeLabel.Text = "Mode: 1";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(611, 603);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counting Game";
            this.TopMost = true;
            this.VisibleChanged += new System.EventHandler(this.MainMenuForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MaxRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetNum)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxRange;
        private System.Windows.Forms.TrackBar DifficultyTrackBar;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.CheckBox ComputerStartsCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TargetNumberLabel;
        private System.Windows.Forms.NumericUpDown TargetNum;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MinRange;
        private System.Windows.Forms.Panel CheckedPanel;
        private System.Windows.Forms.Label ModeLabel;
    }
}