using System;                                      // בס"ד
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Counting_Game_Winform_UI.Forms
{
    public partial class IntroForm : Form
    {
        private MainMenuForm mainMenuForm;
        private WinformCountingGame game1;

        public IntroForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            game1 = new WinformCountingGame();
            mainMenuForm = new MainMenuForm(this, game1);

            game1.AddEventThatExitsApplicationWhenPressESC(this);

            Mode.Maximum = 7;
            Mode.Minimum = 0;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            mainMenuForm.StartPosition = FormStartPosition.Manual;
            mainMenuForm.Location = this.Location;
            mainMenuForm.Show();
            this.Hide();
        }

        private void Mode_ValueChanged(object sender, EventArgs e)
        {
            if (Mode.Value == 7)
                Mode.Value = 1;
            if (Mode.Value == 0)
                Mode.Value = 6;

            game1.Mode = (int)Mode.Value;
            InstructionsLabel.Text = game1.GetInstructions();
        }

    }
}