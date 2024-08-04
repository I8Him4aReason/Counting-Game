using System;                                      // בס"ד                              
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Game_Winform_UI.Forms
{
    public partial class MainMenuForm : Form
    {
        private IntroForm introForm;
        private WinformCountingGame game1;

        public MainMenuForm(IntroForm introForm, WinformCountingGame game1)
        {
            this.introForm = introForm;
            this.game1 = game1;

            InitializeComponent();

            game1.AddEventThatExitsApplicationWhenPressESC(this);
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            introForm.StartPosition = FormStartPosition.Manual;
            introForm.Location = this.Location;
            introForm.Show();
            this.Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            game1.SetTargetNumber((int)TargetNum.Value); 
            game1.SetRange((int)MinRange.Value, (int)MaxRange.Value);
            game1.SetDifficulty(DifficultyTrackBar.Value, DifficultyTrackBar.Maximum);
            game1.ComputerStarts = ComputerStartsCheckBox.Checked;

            GameplayForm gameplayForm = new GameplayForm(this, game1);
            gameplayForm.StartPosition = FormStartPosition.Manual;
            gameplayForm.Location = this.Location;
            gameplayForm.Show();
            this.Hide();
        }


        private void MainMenuForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                if (game1.AdditionMode)
                    TargetNumberLabel.Text = "Target Number:";
                else TargetNumberLabel.Text = "Starting Number:";

                ModeLabel.Text = game1.ModeLabel;
            }
        }


        private void ComputerStartsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckedPanel.BackColor = ComputerStartsCheckBox.Checked ? Color.SpringGreen : Color.Red;
        }

        private void CheckedPanel_Click(object sender, EventArgs e)
        {
            ComputerStartsCheckBox.Checked = !ComputerStartsCheckBox.Checked;
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            TargetNum.Value = 100;
            DifficultyTrackBar.Value = 100;
            MinRange.Value = 1;
            MaxRange.Value = 10;
            ComputerStartsCheckBox.Checked = true;
        }


        private void MinRange_ValueChanged(object sender, EventArgs e)
        {
            MaxRange.Minimum = MinRange.Value + 1;
        }

        private void MaxRange_ValueChanged(object sender, EventArgs e)
        {
            MinRange.Maximum = MaxRange.Value - 1;
        }
    }
}