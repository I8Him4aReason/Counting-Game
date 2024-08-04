namespace Counting_Game_Winform_UI.Forms
{
    partial class GameplayForm
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
            this.BasadLable = new System.Windows.Forms.Label();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.WinLoseLabel = new System.Windows.Forms.Label();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.UserNumber = new System.Windows.Forms.NumericUpDown();
            this.UserAddsLabel = new System.Windows.Forms.Label();
            this.ComputerAddsLabel = new System.Windows.Forms.Label();
            this.AddSubtractButton = new System.Windows.Forms.Button();
            this.GameNumberLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.ComputerPanel = new System.Windows.Forms.Panel();
            this.ComputerNumber = new System.Windows.Forms.Label();
            this.StatPanel = new System.Windows.Forms.Panel();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.ModeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CheatSheetToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserNumber)).BeginInit();
            this.ComputerPanel.SuspendLayout();
            this.StatPanel.SuspendLayout();
            this.ScorePanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasadLable
            // 
            this.BasadLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BasadLable.AutoSize = true;
            this.BasadLable.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BasadLable.ForeColor = System.Drawing.Color.White;
            this.BasadLable.Location = new System.Drawing.Point(531, 9);
            this.BasadLable.Name = "BasadLable";
            this.BasadLable.Size = new System.Drawing.Size(66, 29);
            this.BasadLable.TabIndex = 2;
            this.BasadLable.Text = "בס\"ד";
            this.BasadLable.DoubleClick += new System.EventHandler(this.BasadLable_DoubleClick);
            this.BasadLable.MouseLeave += new System.EventHandler(this.BasadLable_MouseLeave);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.BackColor = System.Drawing.Color.Lime;
            this.BackToMainMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackToMainMenuButton.FlatAppearance.BorderSize = 3;
            this.BackToMainMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BackToMainMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.BackToMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackToMainMenuButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BackToMainMenuButton.Location = new System.Drawing.Point(12, 12);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(132, 68);
            this.BackToMainMenuButton.TabIndex = 4;
            this.BackToMainMenuButton.Text = "Back To Main Menu";
            this.BackToMainMenuButton.UseVisualStyleBackColor = false;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Arial", 34F);
            this.TotalLabel.Location = new System.Drawing.Point(62, 14);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(224, 52);
            this.TotalLabel.TabIndex = 18;
            this.TotalLabel.Text = "Total: 234";
            // 
            // WinLoseLabel
            // 
            this.WinLoseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WinLoseLabel.AutoSize = true;
            this.WinLoseLabel.Font = new System.Drawing.Font("Arial", 34F);
            this.WinLoseLabel.Location = new System.Drawing.Point(20, 515);
            this.WinLoseLabel.Name = "WinLoseLabel";
            this.WinLoseLabel.Size = new System.Drawing.Size(209, 52);
            this.WinLoseLabel.TabIndex = 19;
            this.WinLoseLabel.Text = "You Win!";
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.DifficultyLabel.Location = new System.Drawing.Point(9, 100);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(156, 25);
            this.DifficultyLabel.TabIndex = 20;
            this.DifficultyLabel.Text = "Difficulty: Easy";
            // 
            // TargetLabel
            // 
            this.TargetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetLabel.AutoSize = true;
            this.TargetLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.TargetLabel.Location = new System.Drawing.Point(114, 66);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(121, 25);
            this.TargetLabel.TabIndex = 21;
            this.TargetLabel.Text = "Target: 432";
            // 
            // UserNumber
            // 
            this.UserNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNumber.Location = new System.Drawing.Point(158, 22);
            this.UserNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UserNumber.Name = "UserNumber";
            this.UserNumber.Size = new System.Drawing.Size(114, 35);
            this.UserNumber.TabIndex = 1;
            this.UserNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UserAddsLabel
            // 
            this.UserAddsLabel.AutoSize = true;
            this.UserAddsLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserAddsLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.UserAddsLabel.Location = new System.Drawing.Point(10, 22);
            this.UserAddsLabel.Name = "UserAddsLabel";
            this.UserAddsLabel.Size = new System.Drawing.Size(123, 32);
            this.UserAddsLabel.TabIndex = 23;
            this.UserAddsLabel.Text = "You Add:";
            // 
            // ComputerAddsLabel
            // 
            this.ComputerAddsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerAddsLabel.AutoSize = true;
            this.ComputerAddsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComputerAddsLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.ComputerAddsLabel.Location = new System.Drawing.Point(3, 22);
            this.ComputerAddsLabel.Name = "ComputerAddsLabel";
            this.ComputerAddsLabel.Size = new System.Drawing.Size(264, 32);
            this.ComputerAddsLabel.TabIndex = 24;
            this.ComputerAddsLabel.Text = "The Computer Adds:";
            // 
            // AddSubtractButton
            // 
            this.AddSubtractButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSubtractButton.BackColor = System.Drawing.Color.Lime;
            this.AddSubtractButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddSubtractButton.FlatAppearance.BorderSize = 3;
            this.AddSubtractButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddSubtractButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.AddSubtractButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.AddSubtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSubtractButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddSubtractButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddSubtractButton.Location = new System.Drawing.Point(9, 90);
            this.AddSubtractButton.Name = "AddSubtractButton";
            this.AddSubtractButton.Size = new System.Drawing.Size(277, 50);
            this.AddSubtractButton.TabIndex = 2;
            this.AddSubtractButton.Text = "Subtract From Total";
            this.AddSubtractButton.UseVisualStyleBackColor = false;
            this.AddSubtractButton.Click += new System.EventHandler(this.AddSubtractButton_Click);
            // 
            // GameNumberLabel
            // 
            this.GameNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameNumberLabel.AutoSize = true;
            this.GameNumberLabel.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GameNumberLabel.ForeColor = System.Drawing.Color.White;
            this.GameNumberLabel.Location = new System.Drawing.Point(26, 5);
            this.GameNumberLabel.Name = "GameNumberLabel";
            this.GameNumberLabel.Size = new System.Drawing.Size(177, 51);
            this.GameNumberLabel.TabIndex = 26;
            this.GameNumberLabel.Text = "Game 2";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(84, 56);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(60, 27);
            this.ScoreLabel.TabIndex = 27;
            this.ScoreLabel.Text = "1 - 0";
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayAgainButton.BackColor = System.Drawing.Color.Lime;
            this.PlayAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PlayAgainButton.FlatAppearance.BorderSize = 3;
            this.PlayAgainButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PlayAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.PlayAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgainButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PlayAgainButton.Location = new System.Drawing.Point(386, 508);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(198, 71);
            this.PlayAgainButton.TabIndex = 3;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // ComputerPanel
            // 
            this.ComputerPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComputerPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ComputerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComputerPanel.Controls.Add(this.ComputerNumber);
            this.ComputerPanel.Controls.Add(this.ComputerAddsLabel);
            this.ComputerPanel.Location = new System.Drawing.Point(325, 163);
            this.ComputerPanel.Name = "ComputerPanel";
            this.ComputerPanel.Size = new System.Drawing.Size(277, 162);
            this.ComputerPanel.TabIndex = 29;
            // 
            // ComputerNumber
            // 
            this.ComputerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerNumber.AutoSize = true;
            this.ComputerNumber.BackColor = System.Drawing.Color.Transparent;
            this.ComputerNumber.Font = new System.Drawing.Font("Arial", 26F);
            this.ComputerNumber.Location = new System.Drawing.Point(112, 90);
            this.ComputerNumber.Name = "ComputerNumber";
            this.ComputerNumber.Size = new System.Drawing.Size(55, 40);
            this.ComputerNumber.TabIndex = 25;
            this.ComputerNumber.Text = "34";
            // 
            // StatPanel
            // 
            this.StatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StatPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.StatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatPanel.Controls.Add(this.ModeLabel);
            this.StatPanel.Controls.Add(this.TotalLabel);
            this.StatPanel.Controls.Add(this.DifficultyLabel);
            this.StatPanel.Controls.Add(this.TargetLabel);
            this.StatPanel.Location = new System.Drawing.Point(136, 342);
            this.StatPanel.Name = "StatPanel";
            this.StatPanel.Size = new System.Drawing.Size(357, 144);
            this.StatPanel.TabIndex = 29;
            // 
            // ModeLabel
            // 
            this.ModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.ModeLabel.Location = new System.Drawing.Point(243, 100);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(92, 25);
            this.ModeLabel.TabIndex = 22;
            this.ModeLabel.Text = "Mode: 1";
            // 
            // ScorePanel
            // 
            this.ScorePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScorePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ScorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScorePanel.Controls.Add(this.ResetButton);
            this.ScorePanel.Controls.Add(this.GameNumberLabel);
            this.ScorePanel.Controls.Add(this.ScoreLabel);
            this.ScorePanel.Location = new System.Drawing.Point(197, 12);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(235, 100);
            this.ScorePanel.TabIndex = 29;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ResetButton.FlatAppearance.BorderSize = 3;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(167, 67);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(67, 32);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPanel.Controls.Add(this.UserAddsLabel);
            this.UserPanel.Controls.Add(this.UserNumber);
            this.UserPanel.Controls.Add(this.AddSubtractButton);
            this.UserPanel.Location = new System.Drawing.Point(12, 163);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(295, 162);
            this.UserPanel.TabIndex = 30;
            // 
            // TurnLabel
            // 
            this.TurnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.TurnLabel.ForeColor = System.Drawing.Color.Cyan;
            this.TurnLabel.Location = new System.Drawing.Point(229, 121);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(170, 25);
            this.TurnLabel.TabIndex = 23;
            this.TurnLabel.Text = "Computer\'s Turn";
            // 
            // ModeToolTip
            // 
            this.ModeToolTip.AutoPopDelay = 15000;
            this.ModeToolTip.InitialDelay = 900;
            this.ModeToolTip.ReshowDelay = 100;
            // 
            // CheatSheetToolTip
            // 
            this.CheatSheetToolTip.AutoPopDelay = 15000;
            this.CheatSheetToolTip.InitialDelay = 900;
            this.CheatSheetToolTip.ReshowDelay = 100;
            this.CheatSheetToolTip.ToolTipTitle = "Cheat Sheet:";
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(611, 603);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.StatPanel);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.ComputerPanel);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.WinLoseLabel);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.BasadLable);
            this.Font = new System.Drawing.Font("Arial", 18F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "GameplayForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counting Game";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.GameplayForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.UserNumber)).EndInit();
            this.ComputerPanel.ResumeLayout(false);
            this.ComputerPanel.PerformLayout();
            this.StatPanel.ResumeLayout(false);
            this.StatPanel.PerformLayout();
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BasadLable;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label WinLoseLabel;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.NumericUpDown UserNumber;
        private System.Windows.Forms.Label UserAddsLabel;
        private System.Windows.Forms.Label ComputerAddsLabel;
        private System.Windows.Forms.Button AddSubtractButton;
        private System.Windows.Forms.Label GameNumberLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Panel ComputerPanel;
        private System.Windows.Forms.Panel StatPanel;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label ComputerNumber;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ToolTip ModeToolTip;
        private System.Windows.Forms.ToolTip CheatSheetToolTip;
    }
}